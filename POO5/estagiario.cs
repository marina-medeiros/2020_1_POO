using System;

class MainClass{
  public static void Main(string[] args){
    Estagiario marina = new Estagiario("Marina", "123.456.789-10", "91234-5678");
    marina.SetDias(3);
    marina.SetTurno(2);
    Console.WriteLine("ESTAGIÁRIO:");
    Console.WriteLine(marina.ToString());
  }
}

class Estagiario{
  private string nome, cpf, telefone;
  private Dias dias;
  private Turno turno;
  public Estagiario(string n, string c,  string t){
    if(n.Length > 0) this.nome = n;
    if(c.Length > 0) this.cpf = c;
    if(t.Length > 0) this.telefone = t;
  }
  public void SetDias(int seletor){
    switch (seletor){
      case 1: this.dias = (Dias) 1; break;
      case 2: this.dias = (Dias) 3; break;
      case 3: this.dias = (Dias) 7; break;
      case 4: this.dias = (Dias) 15; break;
      case 5: this.dias = (Dias) 31; break;
    }
  }
  public void SetTurno(int seletor){
    this.turno = (Turno) seletor;
  }
  public Dias GetDias(){
    return dias;
  }
  public Turno GetTurno(){
    return turno;
  }
  public override string ToString(){
    return $"Nome: {nome}\nCPF: {cpf}\nTelefone: {telefone}\nDIAS: {dias}\nTurno: {turno}";
  }
}

[Flags]
enum Dias : int{
  nenhum = 0,
  segunda = 1,
  terca = 2,
  // 3 = segunda, terca
  quarta = 4,
  // 7 = segunda, terca, quarta
  quinta = 8,
  sexta = 16
  // 31 = segunda, terca, quarta, quinta, sexta
}
enum Turno : int{
  matutino = 1, vespertino = 2, noturno = 3
}
