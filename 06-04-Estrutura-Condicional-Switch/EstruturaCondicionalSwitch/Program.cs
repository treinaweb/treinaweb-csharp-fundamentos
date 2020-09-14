using System;

namespace EstruturaCondicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a opção:");
            var opcao = Console.ReadLine();
            switch(opcao)
            {
                case "1":
                Console.WriteLine("Seu saldo é R$ 100,00");
                break;
                case "2":
                Console.WriteLine("Informe o valor do depósito");
                break;
                case "3":
                Console.WriteLine("Informe o valor do saque");
                break;
                default:
                Console.WriteLine("Opção inválida");
                break;
            }
        }
    }
}
