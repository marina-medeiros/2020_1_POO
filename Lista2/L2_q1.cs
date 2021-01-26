using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite seu nome");
    string nome = Console.ReadLine ();
    Console.WriteLine ($"Bem vindo(a) ao C#, {nome}");
  }
}