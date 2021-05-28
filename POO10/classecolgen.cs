using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Aluno x = new Aluno("Marina", 1001);
    Aluno y = new Aluno("Ana", 1002);
    Aluno z = new Aluno("Nanda", 1003);

    Colecao<Aluno> turma = new Colecao<Aluno>();
    turma.Add(x);
    turma.Add(y);
    turma.Add(z);

    foreach (Aluno i in turma) Console.WriteLine(i.ToString());

    Console.WriteLine("x");
    turma.Sort();

    foreach (Aluno i in turma) Console.WriteLine(i.ToString());
  }
}

class Aluno : IComparable<Aluno>{
  public string Nome {get;}
  public int Matricula;
  public Aluno(string n, int m){
    this.Nome = n;
    this.Matricula = m;
  }
  public int CompareTo(Aluno obj){
    return Nome.CompareTo(obj.Nome);
  }
  public override string ToString(){
    return $"{Nome} - {Matricula}";
  }
}

class Colecao<T> :IEnumerable{
  private T[] objs = new T[5];
  private int k = 0;
  public int Count {get => k;}
  public void Add(T obj){
    if(k < objs.Length) objs[k++] = obj;
  }
  public void Remove(T obj){
    int index= Array.IndexOf(objs, obj);
    objs = objs.Where((e, i) => i != index).ToArray();
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

/*
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
*/