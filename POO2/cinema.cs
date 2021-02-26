using System;

class MainClass {
  public static void Main (string[] args) {
    Entrada e = new Entrada();
    Console.WriteLine("Escreva o dia da semana da sessão.");
    e.SetDia((Console.ReadLine()));
    Console.WriteLine("Escreva o horário da sessão no formato hh:mm.");
    string s = Console.ReadLine();
      e.SetHora(int.Parse(s.Substring(0,2)));
    Console.WriteLine("Você é estudante?");
    e.SetEstudante((Console.ReadLine()));
    Console.WriteLine($"O valor da entrada para o sessão de {e.GetDia()} às {e.GetHora()} será de R${e.Valor():0.00}");
  }
}

class Entrada {
  private string dia;
  private int hora;
  private string estudante;
  private double valor;
  public void SetDia(string d){
    if(d.Length > 0) dia = d;
  }
  public void SetEstudante(string est){
    if(est.Length > 0) estudante = est;
  }
  public void SetHora(int h){
    if(h >= 0 && h < 24) h = hora;
  }
  public string GetDia(){
    return dia;
  }
  public string GetEstudante(){
    return estudante;
  }
  public int GetHora(){
    return hora;
  }
  public double Valor() {
    if (dia == "Segunda" || dia == "Terça" || dia == "Quinta"){
      valor = 16;
    }
    if (dia == "Sexta" || dia == "Sábado" || dia == "Domingo"){
      valor = 20;
    }
    if (dia == "Quarta"){
      valor = 8;
      estudante = "Não";
      hora = 0;
    }
    if (hora >= 17) {
      valor = valor * 1.5;
    }
    if (estudante == "Sim") {
      valor = valor / 2;
    }
    return valor;
  }
}


