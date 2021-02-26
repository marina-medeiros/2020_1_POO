using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Questão 02");
    int a = 1;
    int b = 5;
    int c = 3;
    Ordenar(ref a, ref b, ref c);
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
  }

  public static void Ordenar(ref int x, ref int y, ref int z)
  {
    // selection sort
    int aux;
    // x com y
    if (x > y) {
      aux = x;
      x = y;
      y = aux;
    } 
    // x com z
    if (x > z) {
      aux = x;
      x = z;
      z = aux;
    } 
    // y com z
    if (y > z) {
      aux = y;
      y = z;
      z = aux;
    } 
  }

}
  