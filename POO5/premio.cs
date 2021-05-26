using System;

class MainClass{
  public static void Main(string[] args){
    Premio p = new Premio("Marina", DateTime.Parse("05/04/2021"));
    Console.WriteLine("PREMIO:");
    Console.WriteLine(p.ToString());

    ValeCompras v = new ValeCompras(DateTime.Parse("05/04/2021"), Convert.ToDecimal(79.90));
    Console.WriteLine("VALE COMPRAS:");
    Console.WriteLine(v.ToString());

    Produto pd = new Produto("Máquina de barbear - PHILCO", Convert.ToDecimal(79.90));
    Console.WriteLine("PRODUTO:");
    Console.WriteLine(pd.ToString());
  }
}
class Premio{
  private string cliente;
  private DateTime data;
  private object premio;
  public Premio(string c, DateTime d){
    if(c.Length > 0) this.cliente = c;
    this.data = d;
  }
  public void SetPremio(object p){
    this.premio = p;
  }
  public object GetPremio(){
    return premio;
  }
  public override string ToString(){
    return $"CLIENTE:{cliente}\nDATA:{data}";
  }
}
class ValeCompras{
  private DateTime dataValidade;
  private decimal valor;
  public ValeCompras(DateTime d, decimal v){
    this.dataValidade = d;
    this.valor = v;
  }
  public override string ToString(){
    return $"VALIDADE:{dataValidade.ToString("MM/dd/yyyy")}\nVALOR:{valor}";
  }
}
class Produto{
  private string descricao;
  private decimal valor;
  public Produto(string d, decimal v){
    if(d.Length > 0)this.descricao = d;
    this.valor = v;
  }
  public override string ToString(){
    return $"DESCRIÇÃO:{descricao}\nVALOR:{valor}";
  }
}