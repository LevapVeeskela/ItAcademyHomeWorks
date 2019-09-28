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
            var hw = new FirstTaskService();
            hw.ShowEnglishAlphabet();
            hw.ShowEnglishAlphabetFromUnicodeTableDecNumber();
            hw.ShowEnglishAlphabetUnicodeTableEscapeSequence();
            hw.ShowEnglishAlphabetUnicodeTableLinq();
            Console.ReadKey();
        }
    }
}
