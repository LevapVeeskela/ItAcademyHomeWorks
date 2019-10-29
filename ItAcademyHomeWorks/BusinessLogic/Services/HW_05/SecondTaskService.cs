using System;
using System.Collections.Generic;
using System.Linq;
using Common.Constants;
using Common.Extensions;
using Common.Helpers;

namespace BusinessLogic.Services.HW_05
{
    public class SecondTaskService
    {
        public void GetTwoArray()
        {
            int[] array = new int[WriteOrReadConsoleHelper.GetIntValueFromConsole(HomeWorkFive.TextCapacityArrayInfo)];
            for (var i = HomeWorkFive.InitRangeValueDefault; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    array[i] = WriteOrReadConsoleHelper.GetIntValueFromConsole(i);
                }
                else
                {
                    Console.WriteLine(HomeWorkFive.FiftyLines);
                    array.WriteInConsole();
                    var indexValue = WriteOrReadConsoleHelper.GetIntValueFromConsole(HomeWorkFive.TextIndexNewValueInfo, array.Length - 1);
                    var value = WriteOrReadConsoleHelper.GetIntValueFromConsole(indexValue);
                    Console.WriteLine(HomeWorkFive.FiftyLines);
                    array.ShiftElementsArray(indexValue, value);
                    array.WriteInConsole();
                }
            }
        }
    }
}
