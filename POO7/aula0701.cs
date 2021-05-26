using System;

class MainClass{
  public static void Main(string[] args){
    Tringulo x = new Tringulo(10, 20);
    x.SetBase(10);
    x.SetAltura(20);
    //set na propriedade:
    x.Base = 100;
    x.Altura = 200;
    x.Base2 = 200;
    x.Altura2 = 300;
    Console.WriteLine(x.CalcArea());
    //get na propriedade
    Console.WriteLine(x.Area);
  }
}

class Tringulo {
  private double b, h;
  // construtor padrão que n recebe parâmetros:
  public Tringulo() { }
  public Tringulo(double b, double h){
    if(b > 0) this.b = b;
    if(h > 0) this.h = h;
  }
  public double Base{
    get {return b;}
    set{if (value > 0) b = value;}
  }
  public double Altura{
    get {return h;}
    set{if (value > 0) h = value;}
  }
  // xxxxxx
  public double Base2{
    get => b;
    set => b = value > 0 ? value : 0;
  }
  public double Altura2{
    get => h;
    set => h = value > 0 ? value : 0;
  }
  // xxxxxx
  public void SetBase(double v){
    if(v > 0) b = v;
  }
  public double GetBase(){
    return b;
  }
  public void SetAltura(double v){
    if(v > 0) h = v;
  }
  public double GetAltura(){
    return h;
  }
  // xxxxx
  public double CalcArea(){
    double area = b * h / 2;
    return area;
  }
  public double Area {
    get{ return b * h / 2;}
  }
  public override string ToString(){
    return $"Base = {b}, Altura = {h}";
  }
}