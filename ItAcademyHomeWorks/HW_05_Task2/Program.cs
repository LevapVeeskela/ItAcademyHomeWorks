using System;
using BusinessLogic.Services.HW_05;

namespace Task2
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
            Console.ReadKey();
        }
    }
}
