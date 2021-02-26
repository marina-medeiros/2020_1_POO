using System;

class MainClass{
  Retangulo x = new Retangulo(10, 20);
  x.SetBase(10);
  x.SetAltura(20);
  
}

class Retangulo {
  private double b, h;
  public Retangulo(double b, double h){
    if (b > 0) this.b = b;
    if (h > 0) this.h = h;
  }
  public void SetBase(double b) {
    if (b >0) this.b = b;
  }
  public void SetAltura(double h) {
    if (h > 0) this.h = h;
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }
  public double CalcArea(){
    double area = b * h;
    return area;
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}"; 
  }
}

