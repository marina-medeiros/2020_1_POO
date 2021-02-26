using System;

class MainClass {
  public static void Main () {
    Esfera e = new Esfera();
    e.SetRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine($"Volume = {e.CalcVolume()}");
    Console.WriteLine($"Area = {e.CalcArea()}");
  }
}

class Esfera {
  private double raio;
  public void SetRaio(double r) {
    if (r > 0) raio = r;
  }
  public double GetRaio(){
    return raio;
  }
  public double CalcArea(){
    double area = 3.14 * raio * raio;
    return area;
  }
  public double CalcVolume(){
    double volume = 4.19 * raio;
    return volume;
  }
}
