using System;

namespace EstruturaRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var indice = 0;
            var versoes = new[]{ "1.0", "1.1", "2.0", "3.0" };

            while(indice < versoes.Length)
            {
                Console.WriteLine(versoes[indice]);
                indice++;
            }            
        }
    }
}
