using System;
class MainClass {
  public static void main (string[] args){

  }
}
// da errado

class Equacao : Object {
  private double a, b, c;
  public Equacao(double a, double b, double c) {
    this.a = a;
    this.b = b;
    this.c = c;
  }
  public void SetABC(double a){
    if(a == 0) this.a = a;
    this.b = b;
    this.c = c;
  }
  public double GetABC(out double a, out double b, out double c){
    this.a = a;
    this.b = b;
    this.c = c;
  }
  public bool RaizesReais(out double x1, out double x2){
    if (Delta() >= 0){
      x1 = (-b + Math.Sqrt(Delta()))/(2*a);
      x2 = (-b - Math.Sqrt(Delta()))/(2*a);
    }
  }
  public double Delta(){
    return Math.Pow(b, 2) - (4*a*c);
  }
  public override string ToString(){
    return $"As raizes são {x1} e {x2}";
  }
}