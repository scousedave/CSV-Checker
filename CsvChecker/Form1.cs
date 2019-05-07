using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CsvChecker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void qitToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void aboutCSVCheckerToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}


		private void ProcessLines(string filePath, int columns, char delimiter)
		{
			int counter = 1;
			string line;
			var errors = new List<string>();
			var file = new StreamReader(filePath);
			while ( (line = file.ReadLine()) != null)
			{

				string[] parts = line.Split(new[] { delimiter }, StringSplitOptions.RemoveEmptyEntries);
				if (parts.Length != columns)
				{
					errors.Add($"The line at position {counter} has {parts.Length} columns instead of {columns}");
				}

				for (int ii = 0; ii < parts.Length; ii++)
				{
					if(LineChecker.CheckString(parts[ii], out string[] problems))
					{
						foreach (string bad in problems)
						{
							var reason = $"Line {counter} in the file had the following error in column {ii}: {bad}";
							errors.Add(reason);
						}
					}
				}


				errors.Clear();
				counter++;
			}

			file.Close();
		}
	}
}
