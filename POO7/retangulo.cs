using System;

class MainClass{
  public static void Main(string[] args){
    Retangulo x = new Retangulo { Base = 3, Altura = 4};
    Console.WriteLine(x.ToString());
  }
}

class Retangulo{
  private double b, h;
  public double Base{
    get {return b;}
    set{if (value > 0) b = value;}
  }
  public double Altura{
    get {return h;}
    set{if (value > 0) h = value;}
  }
  public double Area{
    get {return b * h;}
  }
  public double Diagonal{
    get {return Math.Sqrt(b * b + h * h);}
  }
  public override string ToString(){
    return $"Base: {b}, Altura: {h}, Diagonal: {Diagonal}";
  }
}