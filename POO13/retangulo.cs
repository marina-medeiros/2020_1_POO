using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Console.WriteLine("1 - Definir um novo retângulo");
    Console.WriteLine("2 - Definir a base");
    Console.WriteLine("3 - Definira altura");
    Console.WriteLine("4 - Calcular a área");
    Console.WriteLine("5 - Calcular a diagonal");
    Console.WriteLine("0 - Fim");
    string s = Console.ReadLine();
    Retangulo r = null;
    while (s != "0"){
      if(s == "1") r = new Retangulo();
      if(s == "2") {
        try {
          Console.WriteLine("Informe o valor da base");
          double b = double.Parse(Console.ReadLine());
          r.SetBase(b);
        }
        catch (ArgumentOutOfRangeException) {
          Console.WriteLine("O valor informado deve ser um número positivo");
        }
      }
      if(s == "3") {
        try {
          Console.WriteLine("Informe o valor da altura");
          double h = double.Parse(Console.ReadLine());
          r.SetAltura(h);
        }
        catch (ArgumentOutOfRangeException) {
          Console.WriteLine("O valor informado deve ser um número positivo");
        }
      }
      if(s == "4") {
        Console.WriteLine($"Área: {r.Area}");
      }
      if(s == "5") {
        Console.WriteLine($"Diagonal {r.Diagonal:0.00}");
      }
      Console.WriteLine("1 - Definir um novo triângulo");
      Console.WriteLine("2 - Definir a base");
      Console.WriteLine("3 - Definira altura");
      Console.WriteLine("4 - Calcular a área");
      Console.WriteLine("5 - Calcular a diagonal");
      Console.WriteLine("0 - Fim");
      s = Console.ReadLine();
    }
  }
}

class Retangulo{
  private double b, h;
  public void SetBase(double v){
    if(v > 0) b = v;
    else{
      throw new ArgumentOutOfRangeException("Base inválida");
    }
  }
  public double GetBase(){
    return b;
  }
  public void SetAltura(double v){
    if(v > 0) h = v; 
    else{
      throw new ArgumentOutOfRangeException("Altura inválida");
    }
  }
  public double GetAltura(){
    return h;
  }
  public double Area { get => b * h;}
  public double Diagonal{ get => Math.Sqrt(b * b + h * h); }
  public override string ToString(){
    return $"Base = {b} Altura = {h} Area = {Area}";
  }
}