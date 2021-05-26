using System;

class MainClass{
  public static void Main(string[] args){
    Paciente Marina = new Paciente("Marina", "91234-5678", "123.456.789-10", DateTime.Parse("01/10/2004"));
    Console.WriteLine(Marina.Idade());
    Console.WriteLine(Marina.ToString());
  }
}

class Paciente{
  private string nome, telefone, cpf;
  private DateTime nascimento;
  public Paciente (string n, string t, string c, DateTime nasc){
    if(n.Length > 0) this.nome = n;
    if(t.Length > 0) this.telefone = t;
    if(c.Length > 0) this.cpf = c;
    this.nascimento = nasc;
  }
  public string Idade(){
    return $"O(a) paciente {nome} tem {((DateTime.Today - nascimento)).Days/365} ano(s)";
  }
  public override string ToString(){
    return $"PACIENTE: {nome}\nCPF: {cpf}\nTELEFONE: {telefone}\nIDADE: {((DateTime.Today - nascimento)).Days/365}";
  }
}