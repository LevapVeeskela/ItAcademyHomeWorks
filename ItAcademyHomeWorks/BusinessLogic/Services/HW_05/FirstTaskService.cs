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
                Constants.HomeWorkFive.InitRangeValueDefault,
                Constants.HomeWorkFive.FinishRangeValueRepeatDefault,
                Constants.HomeWorkFive.InitRangeValueDefault,
                Constants.HomeWorkFive.FinishRangeValueDefault).ToArray();
            int[] secondArray = new int[firstArray.Length];
            for (var i = Constants.HomeWorkFive.InitRangeValueDefault; i < firstArray.Length; i++)
            {
                secondArray[i] = WriteOrReadConsoleHelper.GetIntValueFromConsole(i);
            }
            Console.WriteLine(Constants.HomeWorkFive.FiftyLines);
            var thirdArray = firstArray.GetSummaryArray(secondArray);
            firstArray.WriteInConsole();
            secondArray.WriteInConsole();
            thirdArray.WriteInConsole();
        }
    }
}
