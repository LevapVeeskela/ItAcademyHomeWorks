using System;
using BusinessLogic.Services;
using BusinessLogic.Services.HW_03;

namespace HW_03_Task1
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
