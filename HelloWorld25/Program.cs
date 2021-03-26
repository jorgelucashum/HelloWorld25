using System;

namespace HelloWorld25
{
    class Program
    {
        // Propriedades e oprações com DateTime.
        static void Main(string[] args)
        {
            //Propriedades:

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275); // Construtor (Ano, Mes, Dia, Hora, Minuto, Segundo, Milissegundo).
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();
            string s5 = d.ToString();
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            // Operações:
            /*
            DateTime x = new Datatime(2000, 10, 15);
            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);
            */
            Console.WriteLine("-----------------------------------------------------");

            //Propriedades e operações com TimeSpan
            //Propriedades: 

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            Console.WriteLine("");

            // Operações:
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2);
            TimeSpan dif = t1.Subtract(t2);
            TimeSpan mult = t2.Multiply(2.0);
            TimeSpan div = t2.Divide(2.0);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            Console.ReadLine();
        }
    }
}
