using System;

namespace MutableArray
{
    class Program
    {
        static void Main()
        {
            var hack = new ArrayHack();
            hack.Array[1] = 4;

            Console.WriteLine("{0} - [1] item", hack.Array[1]);
            Console.WriteLine("{0} - Length", hack.Array.Length); //2

            hack.Hacker.Length = 42;

            Console.WriteLine("{0} - [1] item",hack.Array[1]);
            Console.WriteLine("{0} - Length", hack.Array.Length); //42

            hack.Array[13] = 43;
            hack.Array[15] = 45;

            Console.WriteLine("{0} - [13] item", hack.Array[13]);
            Console.WriteLine("{0} - [15] item", hack.Array[15]);

            Console.ReadLine();
        }
    }
}
