using System;

namespace TipoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoje = DateTime.Today;
            var agora = DateTime.Now;
            var data1 = new DateTime(2020, 03, 28);
            var data2 = new DateTime(2020, 03, 28, 11, 25, 30);
            var data3 = DateTime.Parse("15/08/2020 12:21:52");
            Console.WriteLine(hoje);
            Console.WriteLine(agora);
            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3);
            Console.WriteLine(data3.Day);
            Console.WriteLine(data3.Month);
            Console.WriteLine(data3.Year);
            Console.WriteLine(data3.Hour);
            Console.WriteLine(data3.Minute);
            Console.WriteLine(data3.Second);
            Console.WriteLine(data3.AddDays(5));
            Console.WriteLine(data3.AddMonths(-1));
            Console.WriteLine(data3.ToLongDateString());
            Console.WriteLine(data3.ToLongTimeString());
            Console.WriteLine(data3.ToShortDateString());
            Console.WriteLine(data3.ToShortTimeString());            
        }
    }
}
