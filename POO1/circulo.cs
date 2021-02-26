using System;

class MainClass {
  public static void Main (string[] args) {
    double x = Double.Parse(Console.ReadLine());
    double area = Circulo.Area(x);
    double circ = Circulo.Circ(x);
    Console.WriteLine($"{area} e {circ}");
  }
}

class Circulo {
  public static double Area(double a) {
    double b = 3.14 * a * a;
    return b;
  }
  public static double Circ(double a) {
    double b = 6.28 * a;
    return b;
  }
}