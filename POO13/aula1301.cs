using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Console.WriteLine("1 - Definir um novo triângulo");
    Console.WriteLine("2 - Definir a base");
    Console.WriteLine("3 - Definira altura");
    Console.WriteLine("4 - Calcular a área");
    Console.WriteLine("0 - Fim");
    string s = Console.ReadLine();
    Triangulo t = null;
    while (s != "0"){
      if(s == "1") t = new Triangulo();
      if(s == "2") {
        try {
          Console.WriteLine("Informe o valor da base");
          double b = double.Parse(Console.ReadLine());
          t.SetBase(b);
        }
        catch (FormatException) {
          Console.WriteLine("O valor informado não é um número");
        }
        catch (ArgumentOutOfRangeException) {
          Console.WriteLine("O valor informado deve ser um número positivo");
        }
        catch (NullReferenceException) {
          Console.WriteLine("É necessário iniciar o triângulo");
        }
        catch (Exception erro) {
          Console.WriteLine(erro.Message);
        }
      }
      if(s == "3") {
        Console.WriteLine("Informe o valor da altura");
        double h = double.Parse(Console.ReadLine());
        t.SetAltura(h);
      }
      if(s == "4") {
        Console.WriteLine($"Área: {t.CalcArea()}");
      }
      Console.WriteLine("1 - Definir um novo triângulo");
      Console.WriteLine("2 - Definir a base");
      Console.WriteLine("3 - Definira altura");
      Console.WriteLine("4 - Calcular a área");
      Console.WriteLine("0 - Fim");
      s = Console.ReadLine();
    }
  }
}

class Triangulo{
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
  public double CalcArea(){
    double area =  b * h / 2;
    return area;
  }
  public override string ToString(){
    return $"Base = {b} Altura = {h} Area = {CalcArea()}";
  }
}