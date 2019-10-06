using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Helpers
{
    public static class ArrayHelper
    {
        public static IEnumerable<int> GetArrayIntValueRandom(int indexWithStart, int capacity, int startRange, int endRange)
        {
            var randNum = new Random();
            return Enumerable.Repeat(indexWithStart, capacity)
                .Select(i => randNum.Next(startRange, endRange));
        }
    }
}
