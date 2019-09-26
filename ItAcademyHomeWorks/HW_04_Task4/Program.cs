using System;
using BusinessLogic.Services.HW_03;

namespace HW_04_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = new FourthTaskService();
            hw.RunFourthTask();
            Console.ReadKey();
        }
    }
}
