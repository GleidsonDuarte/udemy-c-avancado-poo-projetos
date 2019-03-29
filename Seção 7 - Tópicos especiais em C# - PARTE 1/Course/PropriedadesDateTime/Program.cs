using System;

namespace PropriedadesDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Date: " + d.Day);
            Console.WriteLine("3) Date: " + d.DayOfWeek);
            Console.WriteLine("4) Date: " + d.DayOfYear);
            Console.WriteLine("5) Date: " + d.Hour);
            Console.WriteLine("6) Date: " + d.Kind);
            Console.WriteLine("7) Date: " + d.Millisecond);
            Console.WriteLine("8) Date: " + d.Minute);
            Console.WriteLine("9) Date: " + d.Month);
            Console.WriteLine("10) Date: " + d.Second);
            Console.WriteLine("11) Date: " + d.Ticks);
            Console.WriteLine("12) Date: " + d.TimeOfDay);
            Console.WriteLine("13) Date: " + d.Year);

            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(d.ToLongTimeString());
            Console.WriteLine(d.ToShortDateString());
            Console.WriteLine(d.ToShortTimeString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:fff"));

            DateTime data = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime data2 = data.AddHours(2);
            DateTime data3 = data.AddMinutes(3);
            DateTime data4 = data.AddDays(7);

            Console.WriteLine(data);
            Console.WriteLine(data2);
            Console.WriteLine(data3);
            Console.WriteLine(data4);

            DateTime data5 = new DateTime(2000, 10, 15);
            DateTime data6 = new DateTime(2000, 10, 18);
            TimeSpan t = data6.Subtract(data5);

            Console.WriteLine(t);
        }
    }
}