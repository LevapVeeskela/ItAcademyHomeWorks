using System;
using BusinessLogic.Services.HW_04;

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
            var hw = new SecondTaskService();
            hw.GetSimulateProcessMoving();
            Console.ReadKey();
        }
    }
}
