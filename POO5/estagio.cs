using System;

class MainClass{
  public static void Main(string[] args){
    Estagio caern = new Estagio("Marina", "CAERN");
    caern.Iniciar(DateTime.Parse("01/01/2020"));
    caern.Finalizar(DateTime.Parse("01/10/2020"));
    Console.WriteLine(caern.ToString());
    Console.WriteLine(caern.Situacao());
  }
}

class Estagio{
  private string estagiario, empresa;
  private DateTime dataInicio, dataCancelamento, dataFim;
  private int situacao;
  public Estagio(string est, string emp){
    //quando declara o estagiário, ja cadastra ele para poder iniciar
    this.situacao = (int) SituacaoEstagio.Cadastrado;
    if(est.Length > 0) this.estagiario = est;
    if(emp.Length > 0) this.empresa = emp;
  }
  public bool Iniciar(DateTime data){
    if (this.situacao == 1) {
      // vai iniciar, que é 2, ai pode cancelar ou finalizar
      this.situacao = (int) SituacaoEstagio.Iniciado;
      this.dataInicio = data;
      return true;
    }
    return false;
  }
  public bool Cancelar(DateTime data){
    if(this.situacao == 2) {
      this.situacao = (int) SituacaoEstagio.Cancelado;
      this.dataCancelamento = data;
      return true;
    }
    return false;
  }
  public bool Finalizar(DateTime data){
    if(this.situacao == 2){
      this.situacao = (int) SituacaoEstagio.Finalizado;
      this.dataFim = data;
      return true;
    }
    return false;
  }
  public TimeSpan TempoEstagio(){
    TimeSpan ateFim = dataFim.Subtract(dataInicio);
    TimeSpan ateCanc = dataCancelamento.Subtract(dataInicio);
    if (this.situacao == (int) SituacaoEstagio.Finalizado) {
      return ateFim;
    }else {
      return ateCanc;
    }
  }
  public int Situacao(){
    //não era pra ser int
    return situacao;
  }
  public override string ToString(){
    return $"Estagiário:{estagiario}\nEmpresa: {empresa}\nInício: {dataInicio.ToString("dd/MM/yyyy")}\nCancelamento: {dataCancelamento.ToString("dd/MM/yyyy")}\nFim: {dataFim.ToString("dd/MM/yyyy")}";
  }
}

[Flags]
enum SituacaoEstagio : int {
  Nenhum = 0,
  Cadastrado = 1,
  Iniciado = 2,
  Cancelado = 4,
  Finalizado = 8
}