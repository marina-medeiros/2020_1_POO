using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Frete a = new Frete(100, 5);
    FreteExpresso b = new FreteExpresso(100, 2, 5);
    Console.WriteLine(a);
    Console.WriteLine(b);
  }
}

class Frete {
  protected double distancia;
  protected double peso;
  public virtual decimal ValorFrete {get => Convert.ToDecimal(peso * distancia * 0.01);}
  public Frete(double d, double p){
    this.distancia = d;
    this.peso = p;
  }
  public override string ToString(){
    return $"{ValorFrete} --- Peso: {peso} Distancia: {distancia}";
  }
}

class FreteExpresso : Frete {
  private decimal seguro;
  public override decimal ValorFrete { 
    get => base.ValorFrete * Convert.ToDecimal(2) + (seguro * Convert.ToDecimal(0.01));
  }
  public FreteExpresso(double d, double p, decimal s) : base(d, p){
    this.seguro = s;
  }
  public override string ToString(){
    return $"{ValorFrete} --- Peso: {peso} Distancia: {distancia} Seguro: {seguro}";
  }
}