using System;

class MainClass {
  public static void Main (string[] args){
    Aluno a = new Aluno();
    Console.WriteLine(Aluno.curso);
  }
}

class Aluno {
  public static string curso = "Infoweb";
  private string nome;
  public void SetNome(string n){
    if(n.Length > 0) n = nome;
  }
  public string GetNome(){
    return nome;
  }
}