using System;
using System.Collections;

class MainClass{
  public static void Main(string[] args){
    Aluno a = new Aluno("Pedro", DateTime.Parse("01/01/1992"));
    Aluno b = new Aluno("Arlindo", DateTime.Parse("01/02/1992"));
    Aluno c = new Aluno("Lis", DateTime.Parse("01/03/1992"));
    Aluno[] v = {a, b, c};
    //sort precisa que a classe aluno implemente a classe de comparação
    //Array.Sort(v);
    AlunoNascComp x = new AlunoNascComp();
    // o x do sort vem daqui ^^^
    Array.Sort(v, x);
    foreach(Aluno i in v)Console.WriteLine(i);
    //agora escreve em ordem alfabética ou de nascimento dependendo do sort
  }
}
class Aluno : IComparable{
  private string nome;
  private DateTime nasc;
  public Aluno(string n, DateTime d){
    this.nome = n;
    this.nasc = d;
  }
  public override string ToString(){
    return $"{nome}, {nasc:dd/MM/yyyy}";
  }
  public int CompareTo(object obj){
      Aluno x = (Aluno) obj;
      return this.nome.CompareTo(x.nome);
        //a comparação é feita com o nome do aluno que chama o método + o   aluno passado como parâmetro
          //esse método é chamado pelo método sort da classe Array para fazer com que os elementos do vetor sejam ordenados utilizando o padrão de comparação implementado no método
  }
  public DateTime GetNascimento(){
    return nasc;
    // retorna a data de nasc pq ela ta encapsulada na classe auno
  }
}

class AlunoNascComp : IComparer {
  public int Compare(object x, object y){
    Aluno a = (Aluno)x;
    Aluno b = (Aluno)x;
    return a.GetNascimento().CompareTo(
      b.GetNascimento());
  }
}