using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a base e a altura do retângulo");
    int b = int.Parse(Console.ReadLine ());
    int a = int.Parse(Console.ReadLine());
    double area = a * b ;
    double perimetro = a * 2 + b * 2 ;
    double diagonal = a * a + b * b;
    Console.WriteLine ($"Área: {area}, Perímetro: {perimetro}, Diagonal: {Math.Sqrt(diagonal):0}");
  }
}