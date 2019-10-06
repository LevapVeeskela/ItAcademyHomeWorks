using System;
using BusinessLogic.Services.HW_05;

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
            tts.ReverseArray();
            Console.ReadKey();
        }
    }
}
