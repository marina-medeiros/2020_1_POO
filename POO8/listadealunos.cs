using System;
using System.Collections;

class MainClass{
  public static void Main(string[] args){
    Aluno a = new Aluno {Nome = "Arlindo", Matricula = "202210111", Nascimento = new DateTime(2000, 01, 01)};
    Aluno b = new Aluno {Nome = "Zis", Matricula = "202210123", Nascimento = new DateTime(2000, 02, 01)};
    Aluno c = new Aluno {Nome = "Mari", Matricula = "202210222", Nascimento = new DateTime(2000, 03, 01)};
    Aluno[] v = {a, b, c};

    Console.WriteLine("Ordenando por ordem alfabética");
    Array.Sort(v);
    foreach (Aluno i in v) Console.WriteLine(i);

    AlunoNascimentoComp x = new AlunoNascimentoComp();
    Array.Sort(v, x);
    Console.WriteLine("Ordenando por idade:");
    foreach (Aluno i in v) Console.WriteLine(i);

    AlunoMatriculaComp y = new AlunoMatriculaComp();
    Array.Sort(v, y);
    Console.WriteLine("Ordenando por matrícula:");
    foreach (Aluno i in v) Console.WriteLine(i);

  }
}
class Aluno : IComparable{
  public string Nome {get; set;}
  public string Matricula {get; set;}
  public DateTime Nascimento {get; set;}
  public DateTime GetNascimento(){
    return Nascimento;
  }
  public string GetMatricula(){
    return Matricula;
  }
  public int CompareTo(object obj){
    Aluno x = (Aluno) obj;
    return this.Nome.CompareTo(x.Nome);
  }
  public override string ToString(){
    return $"Aluno\nNome: {Nome}\nMatrícula: {Matricula}\nNascimento: {Nascimento}\n";
  }
}

class AlunoMatriculaComp : IComparer{
  public int Compare(object x, object y){
    Aluno a = (Aluno)x;
    Aluno b = (Aluno)y;
    return a.GetMatricula().CompareTo(b.GetMatricula());
  }
}

class AlunoNascimentoComp : IComparer{
  public int Compare(object x, object y){
    Aluno c = (Aluno)x;
    Aluno d = (Aluno)y;
    return -c.GetNascimento().CompareTo(d.GetNascimento());
  }
}