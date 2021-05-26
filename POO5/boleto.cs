using System;
class MainClass{
  public static void Main (string[] args){
    Boleto conta = new Boleto("Fino, fino, grosso, fino",DateTime.Parse("01/01/2020"), DateTime.Parse("01/10/2020"), Convert.ToDecimal(79.90));
    conta.Pagar(60);
    Console.WriteLine(conta.ToString());
    Console.WriteLine(conta.Situacao());
  }
}
class Boleto{
  private string codBarras;
  private DateTime dateEmissao;
  private DateTime dateVencimento;
  private DateTime datePagto;
  decimal valorBoleto;
  decimal valorPago = 0;
  Pagamento situacaoPagamento = Pagamento.emAberto;

  public Boleto(string cod, DateTime emissao, DateTime venc, decimal valor){
    if(cod.Length > 0)this.codBarras = cod;
    this.dateEmissao = emissao;
    this.dateVencimento = venc;
    this.valorBoleto = valor;
  }
  public void Pagar(decimal valorPago){
    this.valorPago = valorPago;
    Situacao();
  }
  public Pagamento Situacao(){
    Pagamento situacaoAberto = Pagamento.emAberto;
    Pagamento situacaoParcial = Pagamento.pagoParcial;
    Pagamento situacaoPago = Pagamento.pago;
    Pagamento situacaoFinal = situacaoAberto;

    if(valorPago == 0){
      situacaoFinal = situacaoAberto;
      this.situacaoPagamento = situacaoAberto;
    }else if(valorPago > 0 && valorPago < valorBoleto){
      situacaoFinal = situacaoParcial;
      this.situacaoPagamento = situacaoParcial;
      datePagto = DateTime.Now;
    }else if(valorPago >= valorBoleto){
      situacaoFinal = situacaoPago;
      this.situacaoPagamento = situacaoPago;
      datePagto = DateTime.Now;
    }
    return situacaoFinal;

  }
  public override string ToString(){
    return $"CÓDIGO DE BARRAS: {codBarras}\nDATA DE EMISSÃO: {dateEmissao.Date}\nDATA DE VENCIMENTO: {dateVencimento.Date}\nDATA DE PAGAMENTO: {datePagto.Date}\nVALOR DO BOLETO: {valorBoleto}\nVALOR PAGO: {valorPago} \nSituação = {situacaoPagamento}";
  }
}
enum Pagamento{
  emAberto = 1, pagoParcial = 2, pago = 3
}