using System;
using System.Globalization;

namespace TipoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 03);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime data1 = DateTime.Parse("2000-08-15");
            DateTime data2= DateTime.Parse("2000-08-15 13:05:58");
            DateTime data3 = DateTime.Parse("15/08/2000");
            DateTime data4 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3);
            Console.WriteLine(data4);

            DateTime dataExata1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dataExata2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(dataExata1);
            Console.WriteLine(dataExata2);
        }
    }
}
