using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Explicit conversions

            double doublePi = 3.14;
            var floatPi = (float)doublePi;
            var decimalPi = (decimal)doublePi;
            var longPi = (long)doublePi;

            #endregion

            #region Implicit conversions

            long longValue = 9223372036854775807;
            int intValue = 2147483647;
            short shortValue = 32767;
            byte byteValue = 255;

            longValue = intValue;
            longValue = shortValue;
            longValue = byteValue;

            #endregion

            #region Boxing-unboxing

            int i = 123;    // a value type - value on the stack
            object o = i;   // boxing  - value on the heap
            int j = (int)o; // unboxing - value on the stack

            #endregion

            Console.WriteLine($"pi: {doublePi}, newOnePi: {floatPi}, newTwoPi: {decimalPi}, newTreePi: {longPi}, longValue: {longValue}");
            Console.ReadKey();
        }
    }
}
