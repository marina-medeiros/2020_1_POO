using System;

class MainClass {
  public static void Main (string[] args) {
    double km = double.Parse(Console.ReadLine());
    double litros = double.Parse(Console.ReadLine());
    double consumo = km / litros ;
    Console.WriteLine ($"{consumo:0.000} km/l");
  }
}