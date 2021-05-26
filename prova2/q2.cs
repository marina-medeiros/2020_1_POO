using System;

public class MainClass {
  public static void Main (string[] args){
    Aluno a; new Aluno();
    a.SetNome("Meu Nome");
    Console.WriteLine(a.ToString());
  }
}

class Aluno {
  private string nome;
  public void SetNome(string nome){}
  public string GetNome(){
    return nome;
  }
}