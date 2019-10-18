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

            if (WriteOrReadConsoleHelper.GetPromptConfirmation(Constants.HomeWorkSix.TextConfirmInfo))
            {
                var pathVerseBlank = Path.Combine(Constants.HomeWorkSix.PathSolution, Constants.HomeWorkSix.NameFile);
                var fullPathFile = WriteOrReadConsoleHelper.GetPromptConfirmation(pathVerseBlank)
                ? pathVerseBlank
                : Path.Combine(Console.ReadLine());
                verseArray = GetVerseFromFile(new FileInfo(fullPathFile), Constants.HomeWorkSix.DefaultSeparator).ToArray();
            }
            else
            {
                Console.WriteLine(Constants.HomeWorkSix.TextEnterSeparatorInfo);
                var separator = Console.ReadLine();
                Console.WriteLine(string.Format(Constants.HomeWorkSix.PatterEnterVerse, separator));
                verseArray = ReplaceLetter(Console.ReadLine(), Constants.HomeWorkSix.DefaultOriginChangeLetter, Constants.HomeWorkSix.DefaultChangeLetter)?.Split(separator);
            }

            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
            verseArray.WriteInConsole();
        }

        private IEnumerable<string> GetVerseFromFile(FileInfo file, char separator)
        {
            return ReplaceLetter(File.ReadAllText(file.FullName, Encoding.UTF8), Constants.HomeWorkSix.DefaultOriginChangeLetter, Constants.HomeWorkSix.DefaultChangeLetter).Split(separator);
        }

        private string ReplaceLetter(string text, char originLetter, char changeLetter)
        {
            return text.Replace(originLetter, changeLetter);
        }
    }
}
