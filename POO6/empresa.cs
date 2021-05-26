using System;

class MainClass{
  public static void Main(string[] args){
    Empresa e = new Empresa();
    Cliente marina = new Cliente("Marina", "123.456.789-10", 500);
    e.Inserir(marina);
    Cliente arlindo = new Cliente("Arlindo", "456.456.456-23", 600);
    e.Inserir(arlindo);
    Cliente lis = new Cliente("Lis", "789.789.789-99", 800);
    e.Inserir(lis);
    arlindo.SetLimite(600);
    arlindo.SetSocio(lis);
    Console.WriteLine(arlindo.ToString());
    Console.WriteLine(e.Listar());
    foreach(Cliente x in e.Listar())
      Console.WriteLine(x);
  }
}

class Empresa{
  private Cliente[] clientes;
  public void Inserir(Cliente c){
    int aux = 1;
    clientes = new Cliente[aux];
    clientes[aux - 1] = c;
    aux++;
  }
  public Cliente[] Listar(){
    Cliente[] lista = new Cliente[clientes.Length];
    for(int i = 0; i < clientes.Length; i++){
      lista[i] = clientes[i];
    }
    return lista;
  }
}

class Cliente{
  private string nome, cpf;
  private decimal limite;
  private Cliente socio;
  public Cliente(string nome, string cpf, decimal limite){
    if(nome.Length > 0) this.nome = nome;
    if(cpf.Length > 0)this.cpf = cpf;
    this.limite = limite;
  }
  public void SetSocio(Cliente c){
    decimal limiteSociedade = c.GetLimite() + this.GetLimite();
    if(c.GetSocio() == null && this.GetSocio() == null){
      this.socio = c;
      c.socio = this;
      c.SetLimite(limiteSociedade);
      this.SetLimite(limiteSociedade);
    }
  }
  public Cliente GetSocio(){
    return socio;
  }
  public void SetLimite(decimal limite){
    this.limite = limite;
  }
  public decimal GetLimite(){
    return limite;
  }
  public override string ToString(){
    return $"Cliente: {nome}. CPF: {cpf}. Limite: {limite}.";
  }
}