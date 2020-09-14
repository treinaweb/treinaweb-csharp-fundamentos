using System;

namespace EstruturaRepeticaoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new[]{ "Joel", "Fagner", "Felipe" };

            foreach(var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
