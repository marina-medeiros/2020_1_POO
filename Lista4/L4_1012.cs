using System;

class MainClass {
  public static void Main (string[] args) {
  string[] ent = Console.ReadLine().Split(' ');
  double a = double.Parse(ent[0]);
  double b = double.Parse(ent[1]);
  double c = double.Parse(ent[2]);

  double atriangulo = a * c / 2;
  double acirculo = (c * c * 3.14159);
  double atrapezio = ((a + b) * c)/2;
  double aquadrado = (b * b);
  double aretangulo = (a * b);

  Console.WriteLine($"TRIÂNGULO {atriangulo:0.000}");
  Console.WriteLine($"CIRCULO {acirculo:0.000}");
  Console.WriteLine($"TRAPÉZIO {atrapezio:0.000}");
  Console.WriteLine($"QUADRADO {aquadrado:0.000}");
  Console.WriteLine($"RETÂNGULO {aretangulo:0.000}");
  }
}