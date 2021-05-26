using System;

class MainClass{
  public static void Main(string[] args){
    Frete x = new Frete{ Distancia = 10, Peso = 5 };
    Console.WriteLine(x.ToString());
  }
}

class Frete{
  private double distancia, peso;
  public double Distancia{
    get {return distancia;}
    set {if (value > 0) distancia = value;}
  }
  public double Peso{
    get {return peso;}
    set {if (value > 0) peso = value;}
  }
  public double ValorFrete {
    get {return 0.1 * peso * distancia;}
  }
  public override string ToString(){
    return $"Distancia: {distancia} Peso: {peso} Frete: {ValorFrete}";
  }
}