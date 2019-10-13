using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var mp = new MotorcyclePublic("123123", "123ssa333dsda", 300, 35, 20000);
            var mi = new MotorcycleInternal("123123", "123ssa333dsda", 245, 33, 20000, 150, 80);
            var mdi = new MotorcycleDefaultInternal("23123ss", "32111wqqwewqe", 200, 29);
        }
    }
}
