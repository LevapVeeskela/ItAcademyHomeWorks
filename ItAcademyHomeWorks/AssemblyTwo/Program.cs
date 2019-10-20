using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mp = new MotorcyclePublic("AAdsad2", "12321a23213s",300, 40, 20000);
            //var mdi = new MotorcycleDefaultInternal(); // not working because access modifier internal, another dll
            //var mi = new MotorcycleInternal(); // not working because access modifier internal, another dll
        }
    }
}
