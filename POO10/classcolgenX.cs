using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Aluno a1 = new Aluno("Marcos",DateTime.Parse("2003-12-26"));
    Aluno a2 = new Aluno("Ana",DateTime.Parse("2003-12-26"));
    Aluno a3 = new Aluno("Carlos",DateTime.Parse("2003-12-26"));
    Aluno a4 = new Aluno("Bia",DateTime.Parse("2003-12-26"));
    Coleção<Aluno> cAlunos = new Coleção<Aluno>();
    cAlunos.Add(a1);
    cAlunos.Add(a2);
    cAlunos.Add(a3);
    cAlunos.Add(a4);

    foreach (Aluno i in cAlunos) {Console.WriteLine(i);}

    cAlunos.Sort();

    foreach (Aluno i in cAlunos) {Console.WriteLine(i);}
  }
}

class Coleção<T> : IEnumerable {
  private T[] objs = new T[50];
  private int k = 0;
  public int Qtd {get => k;}
  public int Count {get => k;}
  public void Add(T obj) {
    if (Count < 50) {objs[k++] = obj;}
  }
  public void Remove(T obj) {
    int indOf = Array.IndexOf(objs,obj);
    for (int i = indOf; i < objs.Length-1; i++) {
      objs[i] = objs[i-1];
    }
  }
  public void Sort() {
    T[] l = new T[k];
    Array.Copy(objs,l,k);
    Array.Sort(l);
    l.CopyTo(objs,0);
  }
  public IEnumerator GetEnumerator() {
    T[] l = new T[Count];
    Array.Copy(objs,l,Count);
    return l.GetEnumerator();
  }
}

class Aluno : IComparable<Aluno> {
  public string Nome {get;}
  private DateTime nasc;
  public Aluno (string n, DateTime d) {
    Nome = n;
    nasc = d;
  }
  public int CompareTo(Aluno obj) {
    return Nome.CompareTo(obj.Nome);
  }
  public override string ToString() {
    return $"{Nome} ({nasc:dd/MM/yyyy})";
  }
}