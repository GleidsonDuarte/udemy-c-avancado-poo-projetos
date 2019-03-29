using System;

namespace PropriedadesTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan timeSpan = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(timeSpan);

            Console.WriteLine($"Days: {timeSpan.Days}");
            Console.WriteLine($"Hours: {timeSpan.Hours}");
            Console.WriteLine($"Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"Milliseconds: {timeSpan.Milliseconds}");
            Console.WriteLine($"Seconds: {timeSpan.Seconds}");
            Console.WriteLine($"Ticks: {timeSpan.Ticks}");

            Console.WriteLine($"TotalDays: {timeSpan.TotalDays}");
            Console.WriteLine($"TotalHours: {timeSpan.TotalHours}");
            Console.WriteLine($"TotalMinutes: {timeSpan.TotalMinutes}");
            Console.WriteLine($"TotalSeconds: {timeSpan.TotalSeconds}");
            Console.WriteLine($"TotalMilliseconds: {timeSpan.TotalMilliseconds}");

            TimeSpan timeSpan1 = new TimeSpan(1, 30, 10);
            TimeSpan timeSpan2 = new TimeSpan(0, 10, 5);

            TimeSpan soma = timeSpan1.Add(timeSpan2);
            TimeSpan diferenca = timeSpan1.Subtract(timeSpan2);
            TimeSpan multiplicacao = timeSpan2.Multiply(2.0);
            TimeSpan divisao = timeSpan2.Divide(2.0);

            Console.WriteLine(soma);
            Console.WriteLine(diferenca);
            Console.WriteLine(multiplicacao);
            Console.WriteLine(divisao);
        }
    }
}
