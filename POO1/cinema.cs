using System;

class MainClass {
  public static void Main (string[] args) {
    Entrada e = new Entrada();
    Console.WriteLine("Digite o dia da semana. (Ex.: 'Segunda')");
    e.dia = Console.ReadLine();
    Console.WriteLine("Digite o horário no formato hh:mm");
    string h = Console.ReadLine();
      e.hora = int.Parse(h.Substring(0,2));
    Console.WriteLine("Você é estudante (Ex.: 'Não'.)");
    e.est = Console.ReadLine();
    Console.WriteLine($"O valor da entrada será {e.Valor()}");
  }
}

class Entrada {
  public string dia;
  public int hora;
  public string est;
  public double valor;
  public double Valor() {
    if (dia == "Segunda" || dia == "Terça" || dia == "Quinta"){
      valor= 16;
    }
    if (dia == "Sexta" || dia == "Sábado" || dia == "Domingo"){
      valor= 20;
    }
    if (dia == "Quarta"){
      valor= 8;
      est = "Não";
      hora = 0;
    }
    if (hora >= 17) {
      valor = valor * 1.5;
    }
    if (est == "Sim") {
      valor = valor / 2;
    }
    return valor;
    
  }
}