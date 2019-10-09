using System;
using BusinessLogic.Services.HW_06;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            RunTask();
        }

        static void RunTask()
        {
            var sts = new SecondTaskService();
            sts.RemoveWordMaxLengthFromRow();
            sts.SwapMaxWithMinLengthWord();
            sts.CountLetterAndPunctuationMarksInRow();
            sts.ConvertStringInArrayAndSortDescending();
            Console.ReadKey();
        }
    }
}
