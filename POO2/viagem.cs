using System;

class MainClass {
  public static void Main (string[] args) {
    Viagem v = new Viagem();
    Console.WriteLine("Escreva a distancia percorrida em km.");
    v.SetDistancia(double.Parse(Console.ReadLine()));
    Console.WriteLine("Escreva o tempo no formato hh:mm");
    string s =Console.ReadLine();
    v.SetHoras(double.Parse(s.Substring(0,2)));
    v.SetMinutos(double.Parse(s.Substring(3,2)));
    Console.WriteLine($"A velocidade média foi de {v.VelocidadeMedia()}km/h");
  }
}

class Viagem {
  private double distancia, horas, minutos;
  public void SetDistancia(double d){
    if(d > 0) distancia = d;
  }
  public void SetHoras(double h){
    if(h > 0) horas = h;
  }
  public void SetMinutos(double m){
    if(m > 0) minutos = m;
  }
  public double GetDistancia(){
    return distancia;
  }
  public double GetHoras(){
    return horas;
  }
  public double GetMinutos(){
    return minutos;
  }
  public double VelocidadeMedia() {
    double vm = distancia / (horas + minutos/60);
    return vm;
  }
}