using System;

class MainClass{
  public static void Main(string[] args){
    string[] d1 = Console.ReadLine().Split(' ');
    string[] h1 = Console.ReadLine().Split(':');
    string[] d2 = Console.ReadLine().Split(' ');
    string[] h2 =Console.ReadLine().Split(':');

    int seg = int.Parse(h2[2]) - int.Parse(h1[2]);
    int min = int.Parse(h2[1]) - int.Parse(h1[1]);
    int hr = int.Parse(h2[0]) - int.Parse(h1[0]);
    int dia = int.Parse(d2[1]) - int.Parse(d1[1]);
    if(seg < 0)
    {
      seg += 60; min-=1;
    }
    if(min < 0)
    {
      min += 60; hr-=1;
    }
    if(hr < 0)
    {
      hr += 24; dia-=1;
    }
    Console.WriteLine($"{dia} dia(s)");
    Console.WriteLine($"{hr} hora(s)");
    Console.WriteLine($"{min} minuto(s)");
    Console.WriteLine($"{seg} segundo(s)");

  }
}