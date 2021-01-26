using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o intervalo de tempo no formato “HH:MM:SS”");
    string tempo = Console.ReadLine ();
    string[] t = tempo.Split(':');
    int horas = int.Parse(t[0]);
    int minutos = int.Parse(t[1]);
    int segundos = int.Parse(t[2]);
    
    int hs = horas * 3600;
    int ms = minutos * 60;
    int st = hs + ms + segundos;
    double km = st * 300;
    Console.WriteLine ($"A luz percorreu {km} mil km nesse intervalo");
  }
}