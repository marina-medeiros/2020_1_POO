using System;

class MainClass {
  public static void Main (string[] args) {
    Circulo c = new Circulo();
    Console.WriteLine("Escreva o raio do círculo");
    c.SetRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine($"A área do círculo de raio {c.GetRaio()} é {c.Area()} e a circunferência é {c.Circ()}");
  }
}

class Circulo {
  private double r;
  public void SetRaio(double v){
    if(v > 0) r = v;
  }
  public double GetRaio(){
    return r;
  }
  public double Area() {
    double area = 3.14 * r * r;
    return area;
  }
  public double Circ() {
    double circ = 6.28 * r;
    return circ;
  }
}