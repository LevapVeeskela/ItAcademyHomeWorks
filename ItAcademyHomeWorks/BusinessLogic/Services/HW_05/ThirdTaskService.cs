using System;
using System.Diagnostics;
using System.Linq;
using Common.Constants;
using Common.Extensions;
using Common.Helpers;

namespace BusinessLogic.Services.HW_05
{
    public class ThirdTaskService
    {
        public void ReverseArrayCustom()
        {
            var watching = new Stopwatch();
            watching.Start();
            var array = ArrayHelper.GetArrayIntValueRandom(
                HomeWorkFive.InitRangeValueDefault,
                WriteOrReadConsoleHelper.GetIntValueFromConsole(HomeWorkFive.TextCapacityArrayInfo),
                HomeWorkFive.InitRangeValueDefault,
                HomeWorkFive.FinishRangeValueDefault).ToArray();
            var middleCapacity = IsEven(array.Length) ? array.Length / 2 : array.Length / 2 + 1;

            Console.WriteLine(HomeWorkFive.FiftyLines);
            array.WriteInConsole();

            for (var i = HomeWorkFive.InitRangeValueDefault; i < middleCapacity; i++)
            {
                ReplacementValueArray(array, i);
            }
            array.WriteInConsole();
            watching.Stop();
            Console.WriteLine(string.Format(HomeWorkFive.StringPutternCustom, array.Length, watching.ElapsedMilliseconds));
        }

        public void ReverseArrayNative()
        {
            var watching = new Stopwatch();
            watching.Start();
            var array = ArrayHelper.GetArrayIntValueRandom(
                HomeWorkFive.InitRangeValueDefault,
                WriteOrReadConsoleHelper.GetIntValueFromConsole(HomeWorkFive.TextCapacityArrayInfo),
                HomeWorkFive.InitRangeValueDefault,
                HomeWorkFive.FinishRangeValueDefault).ToArray();
            Console.WriteLine(HomeWorkFive.FiftyLines);
            array.WriteInConsole();
            Array.Reverse(array);
            array.WriteInConsole();
            watching.Stop();
            Console.WriteLine(string.Format(HomeWorkFive.StringPutternNative, array.Length, watching.ElapsedMilliseconds));
        }

        private void ReplacementValueArray(int[] array, int index)
        {
            var tempValue = array[index];
            var changeValue = array[array.Length - index - 1];
            array[index] = changeValue;
            array[array.Length - index - 1] = tempValue;
        }

        private bool IsEven(int a)
        {
            return (a & 1) == 0;
        }
    }
}