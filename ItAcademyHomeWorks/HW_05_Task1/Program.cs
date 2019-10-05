using System;
using BusinessLogic.Services.HW_05;

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
            Console.ReadKey();
        }

    }
}
