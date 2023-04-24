using System;

namespace Static_Wilson_Kenny
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integers
            Console.WriteLine("Integer Methods");
            Console.WriteLine("20 + 30 is"+ Calculate.Add(20, 30));
            Console.WriteLine(Calculate.Sub(69, 23));
            Console.WriteLine(Calculate.Mult(6, 25));
            Console.WriteLine(Calculate.Div(20, 5));

            //Floats
            Console.WriteLine("\nFloat Methods");
            Console.WriteLine(Calculate.Add(20.2f, 30.25f));
            Console.WriteLine(Calculate.Sub(69.40f, 23.30f));
            Console.WriteLine(Calculate.Mult(6.9f, 25.42f));
            Console.WriteLine(Calculate.Div(20.2f, 5.2f));

        }
    }
}
