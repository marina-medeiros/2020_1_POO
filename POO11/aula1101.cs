using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    string[] v = new string[5];
    v[0] = "Coleções";
    v[1] = "em";
    v[2] = "C#";
    v[3] = "2020";
    v[4] = "01";
    foreach(string s in v) Console.WriteLine(s);

    Console.WriteLine("  ");

    // ArrayList fica em System.Collections
    // é um vetor q vai crescendo dinamicamente
    // os elementos são referenciados como object
    ArrayList a = new ArrayList();
    a.Add("Coleções");
    a.Add("em");
    a.Add("C#");
    a.Add(2020);
    a.Add(01);
    foreach(object s in a) Console.WriteLine(s);
    
    Console.WriteLine("  ");

    List<string> a2 = new List<string>();
    a2.Add("Coleções");
    a2.Add("em");
    a2.Add("C#");
    //a2.Add(2020); n pode int
    //a2.Add(01);
    foreach(string s in a2) Console.WriteLine(s);

    Console.WriteLine("  ");

    //Queue ou "fila"
    Queue<string> f = new Queue<string>();
    f.Enqueue("Coleções");
    f.Enqueue("em");
    f.Enqueue("C#");
    while(f.Count > 0) 
      Console.WriteLine(f.Dequeue());

    Console.WriteLine("  ");
    //Pilha
    Stack<string> p = new Stack<string>();
    p.Push("Coleções");
    p.Push("em");
    p.Push("C#");
    while(p.Count > 0) 
      Console.WriteLine(p.Pop());
  }
}