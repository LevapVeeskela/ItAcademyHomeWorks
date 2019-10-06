using System;
using System.Linq;
using Common.Constants;
using Common.Extensions;
using Common.Helpers;

namespace BusinessLogic.Services.HW_05
{
    public class FirstTaskService
    {
        public void GetThreeArray()
        {
            var firstArray = ArrayHelper.GetArrayIntValueRandom(
                HomeWorkFive.InitRangeValueDefault,
                HomeWorkFive.FinishRangeValueRepeatDefault,
                HomeWorkFive.InitRangeValueDefault,
                HomeWorkFive.FinishRangeValueDefault).ToArray();
            int[] secondArray = new int[firstArray.Length];
            for (var i = HomeWorkFive.InitRangeValueDefault; i < firstArray.Length; i++)
            {
                secondArray[i] = WriteOrReadConsoleHelper.GetIntValueFromConsole(i);
            }
            Console.WriteLine(HomeWorkFive.FiftyLines);
            var thirdArray = firstArray.GetSummaryArray(secondArray);
            firstArray.WriteInConsole();
            secondArray.WriteInConsole();
            thirdArray.WriteInConsole();
        }
    }
}
