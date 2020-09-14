using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 7;
            var b = 3.0m;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(1 + 2);
            Console.WriteLine(a - 2);

            var c = 10 - b;
            Console.WriteLine(c);
        }
    }
}
