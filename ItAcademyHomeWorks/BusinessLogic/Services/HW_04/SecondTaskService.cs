using System;
using Common.Constants;
using Common.Enums;
using Common.Helpers;

namespace BusinessLogic.Services.HW_04
{
    public class SecondTaskService
    {
        public SecondTaskService()
        {
        }

        public void GetSimulateProcessMoving()
        {
            Console.WriteLine(HomeWorkFour.TextEnterCommandInfo);
            while (true)
            {
                var command = Console.ReadLine();
                int.TryParse(command, out var integerValue);
                if (Enum.IsDefined(typeof(HwFourCommandsEnum), integerValue))
                {
                    Console.WriteLine(HwFourSecondTaskHelper.GetProcessMoving((HwFourCommandsEnum)integerValue));
                    continue;
                }
                Console.WriteLine(HwFourSecondTaskHelper.GetProcessMoving(command));
            }
        }
    }
}