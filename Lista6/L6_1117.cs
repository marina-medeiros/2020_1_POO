using System;

class MainClass {
  public static void Main (string[] args){
    int i = 0;
    double soma = 0;
      while (i < 2){
      double a = double.Parse(Console.ReadLine());
      if (a >= 0 && a <= 10){ soma += a ; i+= 1;} 
      else if ((a < 0) || (a > 10)) Console.WriteLine("nota invalida");
      }
      Console.WriteLine($"media = {soma/2:.00}");
  }
}//