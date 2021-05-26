using System;

class MainClass {
  public static void Main(string[] args){
    Paciente Marina = new Paciente {Nome = "Marina", Telefone = "1234-5678", CPF = "123.456.789-10", Nascimento = new DateTime(2004, 05, 02)};
    Console.WriteLine("oi");
    Console.WriteLine(Marina);
  }
}

class Paciente{
  private string nome, telefone, cpf;
  private DateTime nascimento;
  public string Nome{
    get {return nome;}
    set {if (value.Length > 0) nome = value;}
  }
  public string CPF{
    get {return cpf;}
    set {if (value.Length > 0) cpf = value;}
  }
  public string Telefone{
    get {return telefone;}
    set {if (value.Length > 0) telefone = value;}
  }
  public DateTime Nascimento{
    get {return nascimento;}
    set {nascimento = value;}
  }
  public string Idade{
    get {
      TimeSpan i = (DateTime.Today).Subtract(Nascimento);
      DateTime dt = new DateTime() + i;
      return $"Idade: {dt.ToString("yy")}";
    }
  }

  public override string ToString(){
    return $"Paciente\nNome: {Nome}\nTelefone: {Telefone}\nCPF:{CPF}\n{Idade}";
  }
}