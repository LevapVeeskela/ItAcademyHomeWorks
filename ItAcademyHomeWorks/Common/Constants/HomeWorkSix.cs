using System.IO;

namespace Common.Constants
{
    public static class HomeWorkSix
    {
        public static string PathSolution = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent?.Parent?.Parent?.FullName;
        public const char DefaultSeparator = ';';
        public const char DefaultOriginChangeLetter = 'О';
        public const char DefaultChangeLetter = 'А';
        public const string NameFile = "Hw_6_verse.txt";
        public const string TextConfirmInfo = "Maybe read verse from file";
        public const string TextEnterSeparatorInfo = "Please, enter separator for your verse";
        public const string PatterEnterVerse = "Please, enter the verse into one row dividing it {0}";
    }
}