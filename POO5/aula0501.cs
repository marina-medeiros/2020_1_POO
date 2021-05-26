using System;
using System.Globalization;
using System.Threading;

class MainClass {
  public static void Main(string[] args){
    //para colocar em português:
    CultureInfo ci = new CultureInfo("pt-BR");
    Thread.CurrentThread.CurrentCulture = ci;

    DateTime x =  DateTime.Now;
    Console.WriteLine(x);

    Console.WriteLine(x.Day);
    Console.WriteLine(x.Month);
    Console.WriteLine(x.Year);
    //não fica em português pq pegou de uma enum específica
    Console.WriteLine(x.DayOfWeek);
    Console.WriteLine
    //dia da semana em português
    (ci.DateTimeFotmat.GetDayName(x.DayOfWeek))
    Console.WriteLine(x.DayOfYear);
    Console.WriteLine(x.Hour);
    Console.WriteLine(x.Minute);
    Console.WriteLine(x.Second);

    Console.WriteLine(x.ToString("dd/MM/yyyy"));
    Console.WriteLine(x.ToString("MM/dd/yyyy"));
    Console.WriteLine(x.ToString("ddd"));
    Console.WriteLine(x.ToString("dddd"));
    Console.WriteLine(x.ToString("MMM"));
    Console.WriteLine(x.ToString("MMMM"));
  }
}