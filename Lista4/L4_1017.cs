using System;

class MainClass {
  public static void Main (string[] args) {
    int tempo = int.Parse(Console.ReadLine());
    int vm = int.Parse(Console.ReadLine());

    double km = tempo * vm;
    double consumo = km / 12;

    Console.WriteLine($"{consumo:0.000}");
  }
}