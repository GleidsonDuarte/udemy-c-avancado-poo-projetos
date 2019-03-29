using System;

namespace TipoTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(0, 1, 30);
            Console.WriteLine(t);
            Console.WriteLine(t.Ticks);

            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            TimeSpan tf1 = TimeSpan.FromDays(1.5);
            TimeSpan tf2 = TimeSpan.FromHours(1.5);
            TimeSpan tf3 = TimeSpan.FromMinutes(1.5);
            TimeSpan tf4 = TimeSpan.FromSeconds(1.5);
            TimeSpan tf5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan tf6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(tf1);
            Console.WriteLine(tf2);
            Console.WriteLine(tf3);
            Console.WriteLine(tf4);
            Console.WriteLine(tf5);
            Console.WriteLine(tf6);
        }
    }
}
