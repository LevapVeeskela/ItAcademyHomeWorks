using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Common.Constants;
using Common.Extensions;
using Common.Helpers;

namespace BusinessLogic.Services.HW_06
{
    public class FirstTaskService
    {
        public void GetVerse()
        {
            string[] verseArray;

            if (WriteOrReadConsoleHelper.GetPromptConfirmation(HomeWorkSix.TextConfirmInfo))
            {
                var pathVerseBlank = Path.Combine(HomeWorkSix.PathSolution, HomeWorkSix.NameFile);
                var fullPathFile = WriteOrReadConsoleHelper.GetPromptConfirmation(pathVerseBlank)
                ? pathVerseBlank
                : Path.Combine(Console.ReadLine());
                verseArray = GetVerseFromFile(new FileInfo(fullPathFile), HomeWorkSix.DefaultSeparator).ToArray();
            }
            else
            {
                Console.WriteLine(HomeWorkSix.TextEnterSeparatorInfo);
                var separator = Console.ReadLine();
                Console.WriteLine(string.Format(HomeWorkSix.PatterEnterVerse, separator));
                verseArray = ReplaceLetter(Console.ReadLine(), HomeWorkSix.DefaultOriginChangeLetter, HomeWorkSix.DefaultChangeLetter)?.Split(separator);
            }

            Console.WriteLine(HomeWorkFive.FiftyLines);
            verseArray.WriteInConsole();
        }

        private IEnumerable<string> GetVerseFromFile(FileInfo file, char separator)
        {
            return ReplaceLetter(File.ReadAllText(file.FullName, Encoding.UTF8), HomeWorkSix.DefaultOriginChangeLetter, HomeWorkSix.DefaultChangeLetter).Split(separator);
        }

        private string ReplaceLetter(string text, char originLetter, char changeLetter)
        {
            return text.Replace(originLetter, changeLetter);
        }
    }
}
