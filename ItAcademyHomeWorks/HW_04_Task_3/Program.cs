﻿using System;
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
            hw.CalculateDeposit();
            Console.ReadKey();
        }
    }
}
