using System;

class MainClass {
  public static void Main (string[] args){
    Tringulo x = new Tringulo();
    x.SetBase(10);
    x.SetAltura(20);
    Console.WriteLine(x.CalcArea());
    Console.WriteLine(x.ToString());
    Console.WriteLine(x);
    Console.WriteLine(x.CalcArea());
  }
}

class Tringulo : Object {
  private double b , h;
  public void SetBase(double v){
    if (v > 0) b = v;
  }
  public void SetAltura(double v){
    if (v > 0) h = v;
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }
  public double CalcArea(){
    double area = (b * h) / 2;
    return area;
  }
  public override string ToString(){
    return $"Base = {b}, Altura = {h}";
  }
}