using System;

class MainClass{
  public static void Main (string[] args){
    Pessoa p = new Pessoa("João", DateTime.Parse("01/10/2020"));
    Console.WriteLine(p.DiaNascimento());
    Console.WriteLine(p.DiasVividos().Days);
    Console.WriteLine(p.ToString());
  }
}

class Pessoa {
  private string nome;
  private DateTime nasc;
  public Pessoa (string nome, DateTime nasc){
    this.nome = nome;
    this.nasc = nasc;
  }
  public DayOfWeek DiaNascimento(){
    // retorna o dia da semana do nascimento
    return nasc.DayOfWeek;
  }
  public TimeSpan DiasVividos(){
    // retorna a subtração entre hoje e o dia do nascimento
    return DateTime.Today - nasc;
  }
  public override string ToString(){
    return $"{nome} viveu {DiasVividos().Days} dias";
  }
}