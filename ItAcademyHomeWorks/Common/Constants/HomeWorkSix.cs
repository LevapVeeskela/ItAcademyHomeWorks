using System.IO;

namespace Common.Constants
{
    public static class HomeWorkSix
    {
        public static string PathSolution = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.Parent?.FullName;
        public const char DefaultSeparator = ';';
        public const char DefaultOriginChangeLetter = 'О';
        public const char DefaultChangeLetter = 'А';
        public const char WhiteSpaceSeparator = ' ';
        public const string NameFile = "Hw_6_verse.txt";
        public const string TextConfirmInfo = "Maybe read verse from file";
        public const string TextEnterSeparatorInfo = "Please, enter separator for your verse";
        public const string PatterEnterVerse = "Please, enter the verse into one row dividing it {0}";
        public const string PatternRegexLetter = @"^[a-zA-Z]+$";
        public const string PatterRegexNotLetter = @"[^\w\s]";
        public const string SwapMaxLengthWordString = "MAX";
        public const string TextInfoForEnterRowInfo = "Please, enter row from server words";
        public const string PatterLengthMaxWordRemove = "Remove word with max length, result: {0}";
        public const string PatterSwapMinWithMaxWord = "Swap max with min word, result: {0}";
        public const string PatterResultLetterAndMarksInRow = "Letter in row: {0}, punctuation marks: {1}";
        public const string PatterLengthMinWord = "Length min word: {0}";
        public const string PatterLengthMaxWord = "Length max word: {0}";
    }
}