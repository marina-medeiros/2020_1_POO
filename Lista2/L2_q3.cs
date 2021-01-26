using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a nota do primeiro bimestre da disciplina:");
    int n1 = int.Parse(Console.ReadLine ());
    Console.WriteLine ("Digite a nota do segundo bimestre da disciplina:");
    int n2 = int.Parse(Console.ReadLine ());
    double nota = (n1 * 2 + n2 * 3)/5;
    Console.WriteLine ($"Media parcial: {nota}");
  }
}