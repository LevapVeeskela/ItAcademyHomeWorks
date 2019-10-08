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
            var array = ArrayHelper.GetArrayIntValueRandom(
                HomeWorkFive.InitRangeValueDefault,
                WriteOrReadConsoleHelper.GetIntValueFromConsole(HomeWorkFive.TextCapacityArrayInfo),
                HomeWorkFive.InitRangeValueDefault,
                HomeWorkFive.FinishRangeValueDefault).ToArray();
            var middleCapacity = IsEven(array.Length) ? array.Length / 2 : array.Length / 2 + 1;
            var arrayLength = array.Length;
            Console.WriteLine(HomeWorkFive.FiftyLines);
            array.WriteInConsole();
            watching.Start();
            for (var i = 0; i < middleCapacity; i++)
            {
                ReplacementValueArray(array, i, arrayLength);
            }
            watching.Stop();
            array.WriteInConsole();
            Console.WriteLine(string.Format(HomeWorkFive.StringPutternCustom, array.Length, watching.ElapsedMilliseconds));
        }

        public void ReverseArrayNative()
        {
            var watching = new Stopwatch();
            var array = ArrayHelper.GetArrayIntValueRandom(
                HomeWorkFive.InitRangeValueDefault,
                WriteOrReadConsoleHelper.GetIntValueFromConsole(HomeWorkFive.TextCapacityArrayInfo),
                HomeWorkFive.InitRangeValueDefault,
                HomeWorkFive.FinishRangeValueDefault).ToArray();
            Console.WriteLine(HomeWorkFive.FiftyLines);
            array.WriteInConsole();
            watching.Start();
            Array.Reverse(array);
            watching.Stop();
            array.WriteInConsole();
            Console.WriteLine(string.Format(HomeWorkFive.StringPutternNative, array.Length, watching.ElapsedMilliseconds));
        }

        private void ReplacementValueArray(int[] array, int index, int length)
        {
            var indexChange = length - index - 1;
            var tempValue = array[index];
            array[index] = array[indexChange];
            array[indexChange] = tempValue;
        }

        private bool IsEven(int a)
        {
            return (a & 1) == 0;
        }
    }
}