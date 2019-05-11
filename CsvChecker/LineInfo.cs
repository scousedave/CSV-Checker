using System;
using System.Collections.Generic;
using System.Linq;

namespace CsvChecker
{
	public class LineInfo
	{
		private readonly char[] _separators = new[] {',', '|', ';', ':', '\t', '~'};

		//public readonly SortedDictionary<int, char> SeparatorCounts;
		public Dictionary<char, int> SeparatorCounts { get; }

		public char ChosenSeparator;
		public int ChosenSeparatorCount;

		public string Line { get; }

		public bool IsValid { get; }

		public string ErrorMessage;

			public LineInfo(string line)
			{
				Line = line;
				SeparatorCounts = new Dictionary<char, int>();

				foreach (char c in _separators)
				{
					var result = line.Split(new[] {c}, StringSplitOptions.None);
					if(result.Length > 0) SeparatorCounts.Add(c,result.Length);
				}

				IsValid = SeparatorCounts.Count > 0;
				TryFindBestSeparator(SeparatorCounts, out ChosenSeparator, out ChosenSeparatorCount, out ErrorMessage);
			}


		public static bool TryFindBestSeparator(Dictionary<char, int> separators, out char separator, out int columnCount, out string errorMessage)
		{
			errorMessage = String.Empty;
			if (separators.Count == 0)
			{
				errorMessage = "Cannot find a valid separator character";

				separator = ',';
				columnCount = 9;
				return false;
			}

			var firstLine = separators.First();
			separator = firstLine.Key;
			columnCount = firstLine.Value;

			foreach (KeyValuePair<char, int> info in separators)
			{
				if (info.Value > columnCount)
				{
					separator = info.Key;
					columnCount = info.Value;
				}
			}
			return true;

		}
	}

}
