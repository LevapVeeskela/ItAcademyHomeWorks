using System;
using BusinessLogic.Services.HW_03;

namespace HW_04_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static void RunTask()
        {
            var fts = new FourthTaskService();
            fts.RunFourthTask();
            Console.ReadKey();
        }
    }
}
