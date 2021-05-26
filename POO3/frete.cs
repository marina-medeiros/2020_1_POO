using System;
class MainClass {
  public static void Main (string[] args){
    Frete x = new Frete(10, 20);
    //x.SetPeso(10);
    //x.SetDistancia(20);
    Console.WriteLine(x.ToString());
  }
}

class Frete : Object{
  private double peso, distancia;
  public Frete(double vp, double vd){
    if (vp > 0) peso = vp;
    if (vd > 0) distancia = vd;
  }
  public void SetDistancia(double d){
    if(d > 0) distancia = d;
  }
  public void SetPeso(double p){
    if(p > 0) peso = p;
  }
  public double GetDistancia( ){
    return distancia;
  }
  public double GetPeso(){
    return peso;
  }
  public double CalcFrete(){
    double frete = 0.1 * peso * distancia;
    return frete;
  }
  public override string ToString(){
    return $"O frete será de {CalcFrete()}";
  }

}

