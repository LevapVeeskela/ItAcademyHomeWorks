using System;
using BusinessLogic.Services.HW_03;

namespace HW_04_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask();
        }

        static void RunTask()
        {
            var hw = new ThirdTaskService();
            hw.RunThreeTask();
            Console.ReadKey();
        }
    }
}
