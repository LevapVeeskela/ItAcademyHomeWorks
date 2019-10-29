using System;
using System.Linq;
using Common.Constants;

namespace BusinessLogic.Services.HW_04
{
    public class FirstTaskService
    {
        public void ShowEnglishAlphabet()
        {
            var firstLetter = 'a';
            var endLetter = 'z';
            Console.WriteLine($"Первый пример, {Constants.HomeWorkFour.TextEnglishAlphabetUnicodeInfo}");
            for (var letter = firstLetter; letter <= endLetter; letter++)
            {
                Console.WriteLine($"{letter}-{letter.ToString().ToUpper()}");
            }
        }

        public void ShowEnglishAlphabetFromUnicodeTableDecNumber()
        {
            var firstLetter = 97;
            var endLetter = 122;
            Console.WriteLine($"Второй пример, {Constants.HomeWorkFour.TextEnglishAlphabetUnicodeInfo}");
            for (var letterNumberUnicodeTable = firstLetter; letterNumberUnicodeTable <= endLetter; letterNumberUnicodeTable++)
            {
                Console.WriteLine($"{(char)letterNumberUnicodeTable}-{((char)letterNumberUnicodeTable).ToString().ToUpper()}");
            }
        }

        public void ShowEnglishAlphabetUnicodeTableEscapeSequence()
        {
            var firstLetter = '\u0061';
            var endLetter = '\u007A';
            Console.WriteLine($"Третий пример,{Constants.HomeWorkFour.TextEnglishAlphabetUnicodeInfo}");
            for (var letterNumberUnicodeTable = firstLetter; letterNumberUnicodeTable <= endLetter; letterNumberUnicodeTable++)
            {
                Console.WriteLine($"{letterNumberUnicodeTable}-{letterNumberUnicodeTable.ToString().ToUpper()}");
            }
        }

        public void ShowEnglishAlphabetUnicodeTableLinq()
        {
            var alphabets = Enumerable.Range('a', 26).Select(letter => ((char)letter).ToString()).ToList();
            Console.WriteLine($"Четвертый пример с использованием LINQ, {Constants.HomeWorkFour.TextEnglishAlphabetUnicodeInfo}");
            foreach (var letter in alphabets)
            {
                Console.WriteLine($"{letter}-{letter.ToUpper()}");
            }
        }
    }
}