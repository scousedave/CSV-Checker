using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CsvChecker
{
	public partial class CsvCheckerForm : Form
	{
		private static string _filePath;
		private const char _delimiter = ',';
		private const int _numColumns = 9;
		private const int _linesToParse = 6;
		private bool _error;
		private int _errorCount;
		private long _lineCount;

		public CsvCheckerForm()
		{
			InitializeComponent();
		}


		private void qitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aboutCSVCheckerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string message = $"Copyright © 2019 by David Lawson {Environment.NewLine}Released under the MIT License ";
			string title = "Csv Checker Copyright Information";
			MessageBox.Show(message, title);
		}

		private void buttonProcess_Click(object sender, EventArgs e)
		{
			if (checkParameters())
			{
				var separator = textBoxSeparator.Text.Trim()[0];
				if(int.TryParse(textBoxColumns.Text, out int columns))
				{
					textBoxOutput.Clear();
					_error = false;
					_errorCount = 0;
					Cursor.Current = Cursors.WaitCursor;

					var sw = new Stopwatch();
					sw.Start();
					processLines(_filePath, columns, separator);
					sw.Stop();
					Cursor.Current = Cursors.Default;

					if (!_error)
					{
						MessageBox.Show($"Processed {_lineCount} lines without error.{Environment.NewLine} Processing took {sw.ElapsedMilliseconds / 1000} seconds {Environment.NewLine}File good to go!", "No errors found");
					}
					else
					{
						MessageBox.Show($"Processed {_lineCount} lines. Found {_errorCount} errors in file", "Errors found");
					}
				}
			}
		}

		private void buttonOpenFile_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
				if (result == DialogResult.OK) // Test result.
				{
					string file = openFileDialog1.FileName;

					_filePath = file;
					var fileInfo = new FileInfo(file);
					_lineCount = LineUtility.CountFileLines(fileInfo);
					labelLineCount.Text = _lineCount.ToString();
					textBoxfilePath.Text = file;
					buttonProcess.Enabled = true;
					var lines = LineUtility.ReadFirstLinesInFile(file, _linesToParse);
					if (LineUtility.TryParseLines(lines, out char separator, out int columnCount, out string errorMessage))
					{
						textBoxColumns.Text = columnCount.ToString();
						textBoxSeparator.Text = separator.ToString();
					}
					else
					{
						showError(errorMessage);
					}
				}
			}
			catch (Exception ex)
			{
				showException(ex);
			}

		}



		private void processLines(string filePath, int columns, char delimiter)
		{
			int counter = 1;
			string line;
			var errors = new List<string>();
			try
			{
				var file = new StreamReader(filePath);
				while ((line = file.ReadLine()) != null)
				{

					string[] parts = line.Split(new[] { delimiter }, StringSplitOptions.None);
					if (parts.Length != columns)
					{
						errors.Add($"The line at position {counter} has {parts.Length} columns instead of {columns}");
						_error = true;
					}

					for (int ii = 0; ii < parts.Length; ii++)
					{
						if (LineChecker.CheckString(parts[ii], out string[] problems))
						{
							foreach (string bad in problems)
							{
								var reason = $"Line {counter} in the file had the following error in column {ii}: {bad}";
								errors.Add(reason);
								_error = true;
							}
						}
					}

					_errorCount += errors.Count;
					outputText(errors);
					errors.Clear();
					counter++;
				}

				file.Close();
			}
			catch (Exception e)
			{
				showException(e);
			}
		}

		private bool checkParameters()
		{
			if (string.IsNullOrEmpty(_filePath))
			{
				showError("Path to file to process is missing");
				return false;
			}
			if (!File.Exists(_filePath))
			{
				showError("File to process no longer exists");
				return false;
			}
			if (string.IsNullOrEmpty(textBoxSeparator.Text))
			{
				showError("Column separator is missing");
				return false;
			}
			if (string.IsNullOrEmpty(textBoxColumns.Text))
			{
				showError("Number of columns is missing");
				return false;
			}

			return true;
		}

		private void showException(Exception ex)
		{
			string message = ex.ToString();
			string title = ex.Message;
			MessageBox.Show(message, title);
			_error = true;
		}

		private void outputText(IEnumerable<string> lines)
		{
			var sb = new StringBuilder();
			foreach (string txt in lines)
			{
				sb.AppendLine(txt);
			}
			outputText(sb.ToString());
		}

		private void outputText(string txt)
		{
			textBoxOutput.AppendText(txt);
		}

		private void showError(string txt)
		{
			string message = txt;
			string title = "Error: Unable to proceed!";
			MessageBox.Show(message, title);
			_error = true;
		}
	}
}
