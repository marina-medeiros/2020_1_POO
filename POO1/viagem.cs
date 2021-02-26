using System;

class MainClass {
  public static void Main (string[] args) {
    Viagem v = new Viagem();
    Console.WriteLine("Digite o tempo da viagem no formato hh:mm.");
    string s = Console.ReadLine();
      v.horas = double.Parse(s.Substring(0,2));
      v.minutos = double.Parse(s.Substring(3,2));
    Console.WriteLine("Digite a distância percorrida em km.");
    v.km = int.Parse(Console.ReadLine());
    Console.WriteLine($"{v.Vm()}");
  }
}

class Viagem {
  public double km;
  public double horas;
  public double minutos;
  public double Vm() {
    double vm = km / (horas + minutos/60);
    return vm;
  }
}