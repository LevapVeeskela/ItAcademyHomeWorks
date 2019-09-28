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
            var hw = new FirstTaskService();
            hw.RunFirstTask();
            Console.ReadKey();
        }
    }
}
