using System;

namespace TipoString
{
    class Program
    {
        static void Main(string[] args)
        {   
            var nome = "Joel";
            var sobrenome = "Rodrigues";
            var nomeCompleto = nome + " " + sobrenome;
            var nomeCompleto2 = $"{ nome } { sobrenome }.";

            Console.WriteLine(nomeCompleto.ToUpper());
            Console.WriteLine(nomeCompleto.ToLower());
            Console.WriteLine(nomeCompleto.Substring(4));
            Console.WriteLine(nomeCompleto.Substring(4, 5));
            Console.WriteLine(nomeCompleto.Contains('o'));
            Console.WriteLine(nomeCompleto.Contains("Fa"));
            Console.WriteLine(nomeCompleto.StartsWith("J"));
            Console.WriteLine(nomeCompleto.EndsWith("L"));
            Console.WriteLine(nomeCompleto.IndexOf('e'));
            Console.WriteLine(nomeCompleto.LastIndexOf('e'));
        }
    }
}
