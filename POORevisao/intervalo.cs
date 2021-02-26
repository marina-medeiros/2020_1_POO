using System;

class MainClass {
  public static void Main () {
    Intervalo i = new Intervalo();
    v.SetDistancia(int.Parse(Console.ReadLine()));
    v.SetTempo(int.Parse(Console.ReadLine()));
    Console.WriteLine(v.ToString());
  }
}

class Intervalo {
  private int hora, minuto, segundo;
  public void SetIntervalo(int h, int m, int s) {
    //abluble
  }
  public double GetDistancia(){
    return d;
  }
  public double GetTempo(){
    return t;
  }
  public double CalcVelocidade(){
    double velocidade = d / t;
    return velocidade;
  }
  public override string ToString() {
    return $"Velocidade média = {CalcVelocidade()}km/h"; 
  }
}