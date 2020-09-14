using System;
using Financeiro;
using Orcamento;
using RH;

namespace DefinindoNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaPagar = new ContaPagar();
            var contaReceber = new ContaReceber();
            var funcionario = new Funcionario();
            var folhaPagamento = new RH.FolhaPagamento();

            Console.WriteLine("Hello World!");
        }
    }
}
