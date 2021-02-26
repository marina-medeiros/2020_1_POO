using System;

class MainClass {
  public static void Main (string[] args) {
    Conta c = new Conta();
    Console.WriteLine("Digite o nome do titular da conta.");
    c.titular = Console.ReadLine();
    Console.WriteLine("Digite o numero da conta.");
    c.numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o saldo da conta.");
    c.saldo = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor que quer depositar/sacar.");
    c.valor = double.Parse(Console.ReadLine());
    Console.WriteLine($"O saldo atual da conta pertencente a {c.titular} é R${c.Acao():0.00}");
  }
}

class Conta {
  public string titular;
  public int numero;
  public double saldo;
  public double valor;
  public double Acao() {
    double d = saldo + valor;
    return d;
  }
}
