using System;

namespace OperadoresComparacao
{
    class Program
    {
        static void Main(string[] args)
        {        
            var a = 2;
            var b = 3;    
            var iguais = a == b;
            var diferentes = a != b;
            var maior = a > b;
            var menor = a < b;
            var maiorOuIgual = a >= b;
            var menorOuIgual = a <= b;
            Console.WriteLine(menorOuIgual);
        }
    }
}
