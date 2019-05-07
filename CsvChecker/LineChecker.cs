using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CsvChecker
{
	public static class LineChecker
	{
		public static bool CheckString(string line, out string[] errors)
		{
			var list = new List<string>();
			for (int i = 0; i < line.Length; i++)
			{
				if (CheckForControlChar(line[i], out string error))
				{
					string bad = $"The character at position {i + 1} {error}";
					list.Add(bad);
				}

				if (CheckForOutOfRangeChar(line[i], out error))
				{
					string bad = $"The character at position {i + 1} {error}";
					list.Add(bad);
				}

			}

			errors = list.ToArray();
			return errors.Length > 0;
		}


		public static bool CheckForControlChar(char letter, out string error)
		{
			error = string.Empty;
			if (!Char.IsControl(letter)) return false;

			error = $"The character {letter}[{CharToHexString(letter)}] is a non-printable control char";
			return true;
		}

		public static bool CheckForOutOfRangeChar(char letter, out string error)
		{
			error = string.Empty;
			ushort num = Convert.ToUInt16(letter);

			if ((num >= 32u) && (num <= 126u)) return false;

			error = $"The character {letter}[{CharToHexString(letter)}] is outside of the range of printable ASCII chars";
			return true;
		}

		public static string CharToHexString(char letter)
		{
			string hex = Convert.ToUInt16(letter).ToString("x2");
			return hex;
		}
	}
}
