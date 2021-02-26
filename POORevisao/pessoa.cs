using System;

class MainClass {
  public static void Main () {
    Pessoa p = new Pessoa();
    
  }
}

class Pessoa {
  private string nome;
  private DateTime nascimento;
  public void SetNome(string s) {
    if (s.Length > 0) nome = s;
  }
  p
  public double GetNome(){
    return nome;
  }
  
  public double CalcVelocidade(){
    double velocidade = d / t;
    return velocidade;
  }
  public override string ToString() {
    return $"Velocidade média = {CalcVelocidade()}km/h"; 
  }
}