using System;

namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 5;
            var c = 5;
            var d = 5.0m;
            var e = 5;

            a += 2; //a = a + 2;
            b -= 2; //b = b - 2;
            c *= 2; //c = c * 2;
            d /= 2; //d = d / 2;
            e %= 2; //e = e % 2;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
