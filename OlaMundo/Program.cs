using System;

namespace OlaMundo
{
    /// <summary>
    /// 
    ///The program starts here. 
    ///
    /// </summary>
    
    class Program
    {
        /// <summary>
        /// Simple program design to introduce me to C#.
        /// Simply writes 2 lines "Hello World!" and "Bye World!"
        /// 
        /// in the end checks for an input to keep the window open while the user
        /// wants.
        /// 
        /// </summary>
        /// 
        /// <param name="args">
        /// It also for now takes arguments in even tho it doesn't do anything 
        /// right now
        /// 
        /// </param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bye World!");

            Console.Read();
        }
    }
}
