using System;

class MainClass {
  public static void Main () {
    Viagem v = new Viagem(10, 20);
    v.SetDistancia(int.Parse(Console.ReadLine()));
    v.SetTempo(int.Parse(Console.ReadLine()));
    Console.WriteLine(v.ToString());
  }
}

class Viagem {
  private double d, t;
  public Viagem(double d, double t) {
    if (d > 0) this.d = d;
    if (t > 0) this.t = t;
  }
  public void SetDistancia(double d) {
    if (d > 0) this.d = d;
  }
  public void SetTempo(double t) {
    if (t > 0) this.t = t;
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
    return $"Velocidade média = {CalcVelocidade()}km/h. Distancia = {d}"; 
  }
}
