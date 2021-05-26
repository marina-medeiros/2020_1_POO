using System;
using System.Collections;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Aluno a = new Aluno("Pedro", DateTime.Parse("1992-01-01"));
    Aluno b = new Aluno("Arlindo", DateTime.Parse("1993-01-01"));
    Aluno c = new Aluno("Lis", DateTime.Parse("1991-02-01"));
    Aluno[] v = {a, b, c};
    AlunoNascComp x = new AlunoNascComp();
    Array.Sort(v, x);
    foreach(Aluno i in v)Console.WriteLine(i);

    Relatorio.Aniversariantes(v, 1);

    Professor p1 = new Professor {Nome = "Patricia", Nascimento = DateTime.Parse("1980-01-01")};
    Professor p2 = new Professor {Nome = "Fernando", Nascimento = DateTime.Parse("1980-02-02")};
    Professor[] w = {p1, p2};

    Relatorio.Aniversariantes(w, 1);

    IPessoa[] vw = {a, b, c, p1, p2};
    Relatorio.Aniversariantes(vw, 1);

    Turma t = new Turma();
    t.SetProfessor(p1);
    t.InserirAluno(a);
    t.InserirAluno(b);
    t.InserirAluno(c);

    Console.WriteLine("Dados da turma");
    Console.WriteLine(t);
    foreach(Aluno y in t.ListarAlunos())Console.WriteLine(y.Nome);
    foreach(Aluno y in t.ListarAlunos())Console.WriteLine(y);

    Console.WriteLine("Aniversariantes da turma");
    var z = 
      from Aluno y in t where y.Nascimento.Month == 1 select y;
    foreach(Aluno y in z)
      Console.WriteLine(y);
    
  }
}

class Aluno : IComparable, IPessoa{
  private string nome;
  private DateTime nasc;
  public string Nome {get => nome; set => nome = value;}
  public DateTime Nascimento {
    get => nasc; set => nasc = value;
    }
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
  }
  public DateTime GetNascimento(){
    return nasc;
  }
}


class Professor : IPessoa {
  public string Nome {get; set;}
  public DateTime Nascimento {get; set;}

}

class Turma : IEnumerable {
  private Professor prof;
  private Aluno[] alunos = new Aluno[10];
  private int k;
  public void SetProfessor (Professor p){
    prof = p;
  }
  public void InserirAluno (Aluno a){
    if (k < 10) alunos[k++] = a;
  }
  public Aluno[] ListarAlunos(){
    Aluno[] r = new Aluno[k];
    Array.Copy(alunos, r, k);
    return r;
  }
  public override string ToString(){
    return $"{prof.Nome} - {k} alunos";
  }
  public IEnumerator GetEnumerator(){
    return alunos.GetEnumerator();
  }
}

class Relatorio {
  public static void Aniversariantes (IPessoa[] v, int mes){
    foreach( IPessoa p in v)
      if(p.Nascimento.Month == mes) Console.WriteLine(p.Nome);
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

interface IPessoa{
  string Nome {get; set;}
  DateTime Nascimento {get; set;}
}