using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){

  }
}

class Aluno : IComparable<Aluno>{
  public string Nome {get; set;}
  public int Matricula {get; set;}
  public int CompareTo(Aluno a){
    return Nome.CompareTo(a.Nome);
  }
}

class AlunoMatriculaComp : IComparer{
  public int Compare(object x, object y){
    Aluno a = (Aluno)x;
    Aluno b = (Aluno)y;
    return a.Matricula.CompareTo(b.Matricula);
  }
}

class Colecao<T> :IEnumerable{
  private T[] objs = new T[5];
  private int k;
  public int Count {get;}
  public void Add(T obj){
    if(k < objs.Length) objs[k++] = obj;
  }
  public void Remove(T obj){
    int index= Array.IndexOf(objs, obj);
    objs = objs.Where((e, i) => i != index).ToArray();
  }
  public void Sort(){
    Array.Sort(objs, new AlunoMatriculaComp());
  }
  public IEnumerator<T> GetEnumerator(){
    Aluno[] v = new Aluno[k];
    Array.Copy(alunos, v, k);
    return v.GetEnumerator();
  }
}
