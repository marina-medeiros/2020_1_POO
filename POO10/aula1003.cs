using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Aluno a = new Aluno("Pedro", DateTime.Parse("1992-01-01"));
    Aluno b = new Aluno("Arlindo", DateTime.Parse("1993-01-01"));
    Aluno c = new Aluno("Lis", DateTime.Parse("1991-02-01"));
    Aluno[] v = {a, b, c};
    Array.Sort(v);
    foreach(Aluno i in v)Console.WriteLine(i);    
  }
}

class Aluno : IComparable<Aluno>{
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
  public int CompareTo(Aluno obj){
      return this.nome.CompareTo(obj.nome);
  }
  public DateTime GetNascimento(){
    return nasc;
  }
}
