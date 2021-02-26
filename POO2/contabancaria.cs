using System;

class MainClass {
  public static void Main (string[] args) {
    Conta c = new Conta();
    Console.WriteLine("Escreva o nome do titular da conta");
    c.SetTitular(Console.ReadLine());

    Console.WriteLine("Escreva o número da conta");
    c.SetNumero(int.Parse(Console.ReadLine()));

    Console.WriteLine("Escreva o saldo da conta");
    c.SetSaldo(double.Parse(Console.ReadLine()));

    Console.WriteLine("Escreva o valor que deseja sacar/depositar");
    c.SetValor(double.Parse(Console.ReadLine()));
    Console.WriteLine($"Agora o saldo da conta {c.GetTitular()} é {c.Acao()}");

  }
}

class Conta {
  private string titular;
  private int numero;
  private double saldo;
  private double valor;
  public void SetTitular(string t){
    if(t.Length > 0) titular = t;
  }
  public void SetNumero(int n){
    if(n > 0) numero = n;
  }
  public void SetSaldo(double n){
    if(n > 0) saldo = n;
  }
  public void SetValor(double v){
    valor = v;
  }
  public string GetTitular(){
    return titular;
  }
  public int GetNumero(){
    return numero;
  }
  public double GetSaldo(){
    return saldo;
  }
  public double GetValor(){
    return valor;
  }

  public double Acao() {
    double acao = saldo + valor;
    return acao;
  }
}