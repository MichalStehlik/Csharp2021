using System;
using System.Globalization;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime ted = DateTime.Now;
            Console.WriteLine(ted);
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine(DateTime.MinValue);
            DateTime c1 = new DateTime();
            Console.WriteLine(c1);
            DateTime c2 = new DateTime(2021, 12, 16);
            Console.WriteLine(c2);
            DateTime c3 = new DateTime(2021, 12, 16, 12, 45, 20);
            Console.WriteLine(c3);
            c3 = c3.AddMinutes(45);
            Console.WriteLine(c3);
            TimeSpan dif = c3 - ted;
            Console.WriteLine(dif);
            Console.WriteLine(c2.Subtract(dif));
            Console.WriteLine(c1.Add(dif));

            Console.WriteLine(ted.Day);
            Console.WriteLine(ted.Hour);
            Console.WriteLine(ted.DayOfWeek);
            Console.WriteLine(ted.DayOfWeek == DayOfWeek.Thursday);

            Console.WriteLine(DateTime.UtcNow);

            Console.WriteLine(ted.ToString("MMMM dd, yyyy - HH:mm:ss"));

            var d = DateTime.Parse("16.12.2021");
            Console.WriteLine(d);
            DateTime x;
            var res = DateTime.TryParse("16.12.2021", out x);
            Console.WriteLine(x);

            CultureInfo ci = new CultureInfo("en-US");
            var z = Convert.ToDateTime("12/16/2021 12:10:10", ci);
            Console.WriteLine(z.ToString());
        }
    }
}
