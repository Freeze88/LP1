using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {

            //checks the number of strings on the array
            for (int x = 0; x< args.Length; x++ )
            {
                //prints the contents 1 by 1
                Console.WriteLine("From Outside Came {0}", args[x]);
            }

            //checks an input to stop the cmd from closing
            Console.Read();
        }
    }
}
