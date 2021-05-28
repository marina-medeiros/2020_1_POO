using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Retangulo r = new Retangulo(10, 20);
    Console.WriteLine(r.ToString());
    Quadrado q = new Quadrado(10);
    Console.WriteLine(q.ToString());
  }
}

class Retangulo{
  protected double b;
  private double h;
  public Retangulo(double b, double h){
    if(b > 0) this.b = b;
    if(h > 0) this.h = h;
  }
  public double GetBase(){
    return b;
  }
  public double GetAltura(){
    return h;
  }
  public double CalcArea(){
    return (b * h);
  }
  public double CalcDiagonal(){
    return Math.Sqrt(b * b + h * h);
  }
  public override string ToString(){
    return $"Retangulo: {b} x {h} - Area: {CalcArea()} Diagonal: {CalcDiagonal():0.00}";
  }
}

class Quadrado : Retangulo{
  public Quadrado(double l) : base(l, l){ }
  public override string ToString(){
    return $"Quadrado: {GetBase()} - Area: {CalcArea()} Diagonal: {CalcDiagonal():0.00}";
  }
}