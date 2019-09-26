using System;

namespace Task2
{   
    class Program
    {
        static void Main(string[] args)
        {
            object objectFirstValue = new object();
            Object objectSecondValue = new object();

            string stringFirstValue = "0";
            String stringSecondValue = "string";

            bool boolFirstValue = true;
            Boolean boolSecondValue = false;

            byte byteFirstValue = 0;
            Byte byteSecondValue = 255;

            sbyte sbyteFirstValue = 127;
            SByte sbyteSecondValue = -127;

            short shortFirstValue = -32768;
            Int16 shortSecondValue = 32767;

            ushort ushortFirstValue = 0;
            UInt16 ushortSecondValue = 65535;

            int intFirstValue = -2147483648;
            Int32 intSecondValue = 2147483647;

            uint uintFirstValue = 0;
            UInt32 uintSecondValue = 4294967295;

            long longFirstValue = -9223372036854775808;
            Int64 longSecondValue = 9223372036854775807;

            ulong ulongFirstValue = 0;
            UInt64 ulongSecondValue = 18446744073709551615;

            float floatFirstValue = 0; // -3.4*1038 between 3.4*1038
            Single floatSecondValue = 3.14F;

            double doubleFirstValue = 0;  //±5.0 * 10 ^-324 between ±1.7 * 10^308
            Double doubleSecondValue = 3.14;

            decimal decimalFirstValue = 0; // ±1.0*10-^28 до ±7.9228*10^28
            Decimal decimalSecondValue = 18446744073709551615;

            char charFirstValue = 'A';
            Char charSecondValue = '\x5A';

            object[] tempArray = {
                objectFirstValue, objectSecondValue,
                stringFirstValue, stringSecondValue,
                boolFirstValue, boolSecondValue,
                byteFirstValue, byteSecondValue,
                sbyteFirstValue, sbyteSecondValue,
                shortFirstValue, shortSecondValue,
                ushortFirstValue, ushortSecondValue,
                intFirstValue, intSecondValue,
                uintFirstValue, uintSecondValue,
                longFirstValue, longSecondValue,
                ulongFirstValue, ulongSecondValue,
                floatFirstValue, floatSecondValue,
                doubleFirstValue, doubleSecondValue,
                decimalFirstValue, decimalSecondValue,
                charFirstValue, charSecondValue
            };

            WriteInConsole(tempArray);

            Console.ReadKey();
        }

        private static void WriteInConsole(object[] data)
        {
            foreach (var value in data)
            {
                var nameType = value.GetType().FullName;
                Console.Write($"{nameType} \n");
            }
        }
    }
}
