using System;
using BusinessLogic.Services.HW_04;

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
            var hw = new ТhreeTaskService();
            hw.CalculateDeposit(1000, 2, 12);
            Console.ReadKey();
        }
    }
}
