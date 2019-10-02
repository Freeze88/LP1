using System;

namespace TiposVarios
{
    class Program
    {
        static void Main()
        {
            byte a = 10;
            sbyte b = 20;
            short c = 30;
            ushort d = 40;
            int e = 50;
            uint f = 60;
            long g = 70;
            ulong h = 80;
            char i = '\u00C6';

            Console.Write("{0},{1},{2},{3},{4},{5},{6},{7},{8}", a, b, c, d, e, f, g, h, i);


            Console.WriteLine("\n Hello World!");

            Console.Read();
        }
    }
}
