using System;

namespace TrabalhandoComClasses
{
    class Aluno
    {
        public string Nome;
        public int Idade;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new Aluno();
            aluno1.Nome = "Joel";
            aluno1.Idade = 27;

            var aluno2 = new Aluno();
            aluno2.Nome = "Maria";
            aluno2.Idade = 21;

            Console.WriteLine(aluno2.Nome);
            Console.WriteLine(aluno2.Idade);
        }
    }
}
