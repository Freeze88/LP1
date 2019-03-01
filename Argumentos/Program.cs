using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int x = 0; x< args.Length; x++ ) {
                Console.WriteLine("From Outside Came {0}", args[x]);
            }
            Console.Read();
        }
    }
}
