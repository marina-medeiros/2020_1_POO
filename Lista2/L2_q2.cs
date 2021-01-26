using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite seu nome completo");
    string nome = Console.ReadLine ();
    string[] n =nome.Split(' ');
    string n1 = (n[0]);
    Console.WriteLine ($"Bem vindo(a) ao C#, {n1}");
  }
}
