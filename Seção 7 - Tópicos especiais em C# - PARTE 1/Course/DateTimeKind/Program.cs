using System;

namespace TipoDateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine($"d1: {d1}");
            Console.WriteLine($"d1 kind: {d1.Kind}");
            Console.WriteLine($"d1 to Local: {d1.ToLocalTime()}");
            Console.WriteLine($"d1 to Utc: {d1.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine($"d2: {d2}");
            Console.WriteLine($"d2 kind: {d2.Kind}");
            Console.WriteLine($"d2 to Local: {d2.ToLocalTime()}");
            Console.WriteLine($"d2 to Utc: {d2.ToUniversalTime()}");

            Console.WriteLine();

            Console.WriteLine($"d3: {d3}");
            Console.WriteLine($"d3 kind: {d3.Kind}");
            Console.WriteLine($"d3 to Local: {d3.ToLocalTime()}");
            Console.WriteLine($"d3 to Utc: {d3.ToUniversalTime()}");

            DateTime data1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime data2 = DateTime.Parse("2000-08-15T 13:05:58Z");

            Console.WriteLine($"data1: {data1}");
            Console.WriteLine($"data1 kind: {data1}");
            Console.WriteLine($"data1 to Local: {data1}");
            Console.WriteLine($"data1 Utc: {data1}");

            Console.WriteLine();

            Console.WriteLine($"data2: {data2}");
            Console.WriteLine($"data2 kind: {data2}");
            Console.WriteLine($"data2 to Local: {data2}");
            Console.WriteLine($"data2 to Utc: {data2}");

            Console.WriteLine();

            Console.WriteLine(data2.ToString("yyyy-MMddTHH:mm:ssZ")); // Cuidado!
            Console.WriteLine(data2.ToUniversalTime().ToString("yyyy-MMddTHH:mm:ssZ"));
        }
    }
}
