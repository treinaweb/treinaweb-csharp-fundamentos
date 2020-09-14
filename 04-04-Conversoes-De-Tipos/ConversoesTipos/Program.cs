using System;

namespace ConversoesTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal taxa  = 12.98m;
            DateTime data = DateTime.Now;
            string taxa2 = taxa.ToString();
            string data2 = data.ToString();

            string resposta = "12";
            int idade = int.Parse(resposta);
            int idade2 = Convert.ToInt32(resposta);

            Console.WriteLine(idade2);
        }
    }
}
