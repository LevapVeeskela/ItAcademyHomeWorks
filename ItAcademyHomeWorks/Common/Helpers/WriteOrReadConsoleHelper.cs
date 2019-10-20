using System;
using static Common.Constants.Constants;

namespace Common.Helpers
{
    public static class WriteOrReadConsoleHelper
    {
        public static bool GetPromptConfirmation(string confirmText)
        {
            Console.Write(WriteOrReadConsole.PatternTextPromptConfirmationInfo, confirmText);

            var response = Console.ReadKey(false).Key;

            return response == ConsoleKey.Y;
        }

        public static string GetStringValueFromConsole(string textInfo)
        {
            Console.WriteLine(textInfo);

            return Console.ReadLine();
        }

        public static int GetIntValueFromConsole()
        {
            Console.WriteLine(WriteOrReadConsole.TextEnterValueInfo);

            return GetIntValue();
        }

        public static int GetIntValueFromConsole(int indexItem)
        {
            var index = indexItem + 1;
            Console.WriteLine(WriteOrReadConsole.TextEnterValueIndexInfo, index);
            return GetIntValue();
        }

        public static int GetIntValueFromConsole(int indexItem, int limitation)
        {
            var index = indexItem + 1;

            Console.WriteLine(WriteOrReadConsole.TextEnterValueIndexInfo, index);

            return GetIntValue(limitation);
        }

        public static int GetIntValueFromConsole(string textInfo)
        {
            Console.WriteLine(textInfo);

            return GetIntValue();
        }
        public static int GetIntValueFromConsole(string textInfo, int limitation)
        {
            Console.WriteLine(textInfo);

            return GetIntValue(limitation);
        }

        private static int GetIntValue()
        {
            var isIntValue = int.TryParse(Console.ReadLine(), out var integerValue);

            while (!isIntValue)
            {
                Console.WriteLine(WriteOrReadConsole.TextEnterValueAgainInfo);
                isIntValue = int.TryParse(Console.ReadLine(), out integerValue);
            }

            return integerValue;
        }

        private static int GetIntValue(int limitation)
        {
            var isIntValue = int.TryParse(Console.ReadLine(), out var integerValue);

            while (!isIntValue || integerValue > limitation)
            {
                Console.WriteLine(WriteOrReadConsole.TextEnterValueAgainInfo);
                isIntValue = int.TryParse(Console.ReadLine(), out integerValue);
            }

            return integerValue;
        }
    }
}