using System;

namespace EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);
        }
    }
}
