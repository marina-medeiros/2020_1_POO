using System;

class MainClass {
  public static void Main (string[] args) {
  string[] ent = Console.ReadLine().Split(' ');
  int a = int.Parse(ent[0]);
  int b = int.Parse(ent[1]);
  int c = int.Parse(ent[2]);
  int d = int.Parse(ent[3]);

  if (b > c && d > a && (c+d) > (b + a) && c > 0 && d > 0 && a % 2 == 0)
    Console.WriteLine("Valores aceitos");
    else
    Console.WriteLine("Valores nao aceitos");

  }
}