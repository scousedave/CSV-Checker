using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;

namespace CsvChecker
{
	public static class LineUtility
	{
		private const char _cr = '\r';
		private const char _lf = '\n';
		private const char _null = (char)0;


		public static long CountFileLines(FileInfo file)
		{
			long count;
			using (var reader = new StreamReader(file.FullName))
			{
				count = CountLines(reader.BaseStream);
			}

			return count;
		}

		public static long CountLines(Stream stream)
		{
			var lineCount = 0L;

			var byteBuffer = new byte[1024 * 1024];
			var detectedEol = _null;
			var currentChar = _null;

			int bytesRead;
			while ((bytesRead = stream.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
			{
				for (var i = 0; i < bytesRead; i++)
				{
					currentChar = (char)byteBuffer[i];

					if (detectedEol != _null)
					{
						if (currentChar == detectedEol)
						{
							lineCount++;
						}
					}
					else if (currentChar == _lf || currentChar == _cr)
					{
						detectedEol = currentChar;
						lineCount++;
					}
				}
			}

			// We had a NON-EOL character at the end without a new line
			if (currentChar != _lf && currentChar != _cr && currentChar != _null)
			{
				lineCount++;
			}
			return lineCount;
		}

		public static string[] ReadFirstLinesInFile(string pathToFile, int numberOfLines)
		{
			var list = new List<string>(numberOfLines);

			using (StreamReader reader = new StreamReader(pathToFile))
			{
				if (numberOfLines > 1)// throw away any potential header line
				{
					reader.ReadLine();
					--numberOfLines;
				}

				for (int i = 0; i < numberOfLines; i++)
				{
					//var line = reader.ReadLine() ?? "";
					var line = reader.ReadLine() ?? "";
					if(!string.IsNullOrWhiteSpace(line))list.Add(line);
				}
			}

			return list.ToArray();
		}


		public static bool TryParseLines(string[] lines, out char separator, out int columnCount, out string errorMessage)
		{
			errorMessage = String.Empty;
			var separatorCounts = new Dictionary<char, int>();

			foreach (string line in lines)
			{
				var lineInfo = new LineInfo(line);
				if (lineInfo.IsValid)
				{
					if (separatorCounts.ContainsKey(lineInfo.ChosenSeparator))
					{
						separatorCounts[lineInfo.ChosenSeparator] += lineInfo.ChosenSeparatorCount;
					}
					else
					{
						separatorCounts.Add(lineInfo.ChosenSeparator, lineInfo.ChosenSeparatorCount);
					}
				}
			}

			var keys = separatorCounts.Keys;
			foreach (char key in keys.ToArray())
			{
				if (separatorCounts[key] == 0)
				{
					separatorCounts.Remove(key);
				}
				else
				{
					separatorCounts[key] = (separatorCounts[key] - 1) / lines.Length + 1;
				}

			}
			return LineInfo.TryFindBestSeparator(separatorCounts, out separator, out columnCount, out errorMessage);

		}
	}
}
