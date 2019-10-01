using System;
using BusinessLogic.Services.HW_04;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static void RunTask()
        {
            var fts = new FirstTaskService();
            fts.ShowEnglishAlphabet();
            fts.ShowEnglishAlphabetFromUnicodeTableDecNumber();
            fts.ShowEnglishAlphabetUnicodeTableEscapeSequence();
            fts.ShowEnglishAlphabetUnicodeTableLinq();
            Console.ReadKey();
        }
    }
}
