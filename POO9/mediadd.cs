using System;
using System.Collections;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    IDisciplina h = new DisciplinaAnual("historia", 10, 8, 7, 4, 3, 7);
    IDisciplina f = new DisciplinaSemestral("fisica", 10, 8, 7, 4);
    Console.WriteLine(f);
    Console.WriteLine(h.CalcMediaParcial());
    Console.WriteLine(h.CalcMediaFinal());

    IDisciplina[] x = new IDisciplina[2];
    x[0] = new DisciplinaAnual("POO", 10, 10, 8, 7, 2, 9);
    x[1] = new DisciplinaSemestral("Filosofia", 10, 5, 4 ,8);
    foreach (IDisciplina dd in x)Console.WriteLine(dd.ToString());

    object[] w = new object[2];
      w[0] = new DisciplinaAnual("Matemática", 10, 8, 7, 9, 7, 0);
      w[1] = new DisciplinaSemestral("SIP", 10, 8, 7, 9);
      foreach(object o in w)Console.WriteLine($"{o.ToString()}");

  }
}

class DisciplinaAnual : IDisciplina{
  private string nome;
  private int nota1, nota2, nota3, nota4, rec, notaFinal;
  public DisciplinaAnual(string n, int n1, int n2, int n3, int n4, int nf, int r){
    this.nome = n;
    this.nota1 = n1;
    this.nota2 = n2;
    this.nota3 = n3;
    this.nota4 = n4;
    this.rec = r;
    this.notaFinal = nf;
  }
  public string GetNome(){
    return nome;
  }
  public int CalcMediaParcial(){
    int media = (nota1 + nota2 + nota3 + nota4) / 4;
    return media;
  }
  public int CalcMediaFinal(){
    int m = (nota1 + nota2 + nota3 + nota4) / 4;
    notaFinal = (m + rec)/ 2;
    return notaFinal;
  }
  public override string ToString(){
    return $"{nome} {nota1} {nota2} {nota3} {nota4} {rec} {notaFinal}";
  }
}

class DisciplinaSemestral : IDisciplina{
  private string nome;
  private int nota1, nota2, rec, notaFinal;
  public DisciplinaSemestral(string n, int n1, int n2, int nf, int r){
    this.nome = n;
    this.nota1 = n1;
    this.nota2 = n2;
    this.rec = r;
    this.notaFinal = nf;
  }
  public string GetNome(){
    return nome;
  }
  public int CalcMediaParcial(){
    int media = (nota1 + nota2) / 2;
    return media;
  }
  public int CalcMediaFinal(){
    int m = (nota1 + nota2) / 2;
    notaFinal = (m + rec)/ 2;
    return notaFinal;
  }
  public override string ToString(){
    return $"{nome} {nota1} {nota2} {rec} {notaFinal}";
  }
}

interface IDisciplina{
  string GetNome();
  int CalcMediaParcial();
  int CalcMediaFinal();
}
