using System;
using BusinessLogic.Services.HW_06;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static void RunTask()
        {
            var tts = new ThirdTaskService();
            Console.ReadKey();
        }
    }
}