using System;
using System.Collections.Generic;
using System.Linq;
using Common.Constants;

namespace Common.Extensions
{
    public static class ArrayExtensions
    {
        public static int[] GetSummaryArray(this IEnumerable<int> a, int[] b)
        {
            return a.Zip(b, (x, y) => x + y).ToArray();
        }

        public static void WriteInConsole<T>(this IEnumerable<T> array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Common.Constants.Constants.HomeWorkFive.FiftyLines);
        }

        /// <summary>
        /// Задаёт новое значение элемента в указанном индексе и сдвигает правую часть.
        /// </summary>
        /// <typeparam name="T">Любой тип.</typeparam>
        /// <param name="originCollection">Массив элементов.</param>
        /// <param name="replaceableIndex">Индекс заменяемого элемента.</param>
        /// <param name="newValue">Новое значение.</param>
        /// <returns>Массив.</returns>
        public static T[] ShiftElementsArray<T>(this T[] originCollection, int replaceableIndex, T newValue)
        {
            var rightPatchArray = originCollection.Where((el, index) => index >= replaceableIndex && index != originCollection.Length - 1).ToArray();
            Array.Copy(rightPatchArray, 0, originCollection, replaceableIndex + 1, rightPatchArray.Length);
            originCollection[replaceableIndex] = newValue;
            return originCollection;
        }
    }
}
