using System;
using BusinessLogic.Services.HW_06;

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
            fts.GetVerse();
            Console.ReadKey();
        }
    }
}
