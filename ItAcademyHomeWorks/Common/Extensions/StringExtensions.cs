using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Common.Constants;
using Common.Models;

namespace Common.Extensions
{
    public static class StringExtensions
    {
        public static string GetMaxWord(this string row)
        {
            return row.Split(Constants.Constants.HomeWorkSix.WhiteSpaceSeparator).OrderBy(word => word.Length).LastOrDefault();
        }

        public static string GetMinWord(this string row)
        {
            return row.Split(Constants.Constants.HomeWorkSix.WhiteSpaceSeparator).OrderBy(word => word.Length).FirstOrDefault();
        }

        public static string GetMaxWordAlternative(this string row)
        {
            return row.Split(Constants.Constants.HomeWorkSix.WhiteSpaceSeparator)
                .Aggregate("", (wordMax, word) => wordMax.Length > word.Length ? wordMax : word);
        }

        public static RowInfoModel GetInfoAboutRow(this string row)
        {
            var arrayRow = row.Split(Constants.Constants.HomeWorkSix.WhiteSpaceSeparator).OrderByDescending(x => x.Length).ToArray();
            return new RowInfoModel
            {
                OriginRow = row,
                ArrayRow = row.Split(Constants.Constants.HomeWorkSix.WhiteSpaceSeparator).OrderByDescending(x => x.Length).ToArray(),
                MaxWord = arrayRow.FirstOrDefault(),
                MinWord = arrayRow.LastOrDefault()
            };
        }

        /// <summary>
        /// Get count letter in row only
        /// </summary>
        /// <param name="row">Origin row</param>
        /// <returns></returns>
        public static int GetCountLettersFromRow(this string row)
        {
            var regex = new Regex(Constants.Constants.HomeWorkSix.PatternRegexLetter, RegexOptions.IgnoreCase);
            return row.Count(letter => regex.IsMatch(letter.ToString()));
        }

        /// <summary>
        /// Get count punctuation marks in row
        /// </summary>
        /// <param name="row">Origin row</param>
        /// <returns></returns>
        public static int GetCountPunctuationMarksFromRow(this string row)
        {
            var regex = new Regex(Constants.Constants.HomeWorkSix.PatterRegexNotLetter, RegexOptions.IgnoreCase);
            return row.Count(letter => regex.IsMatch(letter.ToString()));
        }
    }
}
