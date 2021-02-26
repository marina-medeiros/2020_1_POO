using System;

class MainClass {
  public static void Main () {
    Triangulo x = new Triangulo();
    x.SetBase(10);
    x.SetAltura(20);
    Triangulo y = new Triangulo(10, 20);
    Console.WriteLine(x);
    Console.WriteLine(y.ToString());
  }
}

class Triangulo {
  private double b, h;
  public Triangulo() { }
  public Triangulo(double b, double h) {
    if (b > 0) this.b = b;
    if (h > 0) this.h = h;
  }
  public void SetBase(double b) {
    if (b >0) this.b = b;
  }

  public void SetAltura(double h) {
    if (h > 0) this.h = h;
  }

  public override string ToString() {
    return $"Base = {b}, Altura = {h}"; 
  }
}

