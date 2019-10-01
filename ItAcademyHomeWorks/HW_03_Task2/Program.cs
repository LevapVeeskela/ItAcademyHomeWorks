using System;
using BusinessLogic.Services.HW_03;

namespace HW_03_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static void RunTask()
        {
            var sts = new SecondTaskService();
            sts.RunSecondTask();
            Console.ReadKey();
        }
    }
}
