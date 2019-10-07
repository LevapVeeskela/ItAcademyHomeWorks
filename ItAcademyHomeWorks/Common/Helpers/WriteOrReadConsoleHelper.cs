using System;

namespace Common.Helpers
{
    public static class WriteOrReadConsoleHelper
    {
        public static bool GetPromptConfirmation(string confirmText)
        {
            Console.Write($"{confirmText} [y/n] : ");
            var response = Console.ReadKey(false).Key;
            Console.WriteLine();
            return response == ConsoleKey.Y;
        }
        
        public static string GetStringValueFromConsole(string textInfo)
        {
            Console.WriteLine(textInfo);
            return Console.ReadLine();
        }

        public static int GetIntValueFromConsole()
        {
            Console.WriteLine("Please, enter number");
            return GetIntValue();
        }

        public static int GetIntValueFromConsole(int indexItem)
        {
            Console.WriteLine($"Please, enter {indexItem + 1} element of array");
            return GetIntValue();
        }
        
        public static int GetIntValueFromConsole(int indexItem, int limitation)
        {
            Console.WriteLine($"Please, enter {indexItem + 1} element of array");
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
                Console.WriteLine("Please, try to enter again");
                isIntValue = int.TryParse(Console.ReadLine(), out integerValue);
            };
            return integerValue;
        }

        private static int GetIntValue(int limitation)
        {
            var isIntValue = int.TryParse(Console.ReadLine(), out var integerValue);
            while (!isIntValue || integerValue > limitation)
            {
                Console.WriteLine("Please, try to enter again");
                isIntValue = int.TryParse(Console.ReadLine(), out integerValue);
            };
            return integerValue;
        }
    }
}