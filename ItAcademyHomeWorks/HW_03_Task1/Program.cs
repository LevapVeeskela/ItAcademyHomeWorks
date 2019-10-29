using System;
using BusinessLogic.Services.HW_03;

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
            fts.RunFirstTask();
            Console.ReadKey();
        }
    }
}
