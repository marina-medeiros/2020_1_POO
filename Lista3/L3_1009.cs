using System;

class MainClass {
  public static void Main (string[] args) {
    string nome = Console.ReadLine ();
    double sfixo = double.Parse(Console.ReadLine());
    double comissao = double.Parse(Console.ReadLine());
    double salario = sfixo + (comissao * 0.15);
    Console.WriteLine ($"TOTAL = R${salario:0.00}");
  }
}