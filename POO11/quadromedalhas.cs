using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    QuadroMedalhas<Pais> q = new QuadroMedalhas<Pais>();

    Pais a = new Pais("Alemanha", 2, 3, 1);
    Pais b = new Pais("Brasil", 3, 4, 1);
    Pais c = new Pais("Colômbia", 2, 2, 2);
    Pais d = new Pais("Chile", 3, 5, 1);
    
    q.Inserir(a);
    q.Inserir(b);
    q.Inserir(c);
    q.Inserir(d);

    foreach(Pais p in q.Listar())Console.WriteLine(p.ToString());
    
  }
}

class QuadroMedalhas<Pais>{
  private List<Pais> paises = new List<Pais>();
  public void Inserir(Pais p){
    paises.Add(p);
  }
  public List<Pais> Listar(){
    paises.Sort();
    return paises;
  }
}

//List<Order> SortedList = objListOrder.OrderBy(o=>o.OrderDate).ToList();
//objListOrder.Sort((x, y) => x.OrderDate.CompareTo(y.OrderDate));
/*
class QuadroMedalhas<Pais> : IEnumerable{
public IEnumerator GetEnumerator(){
    paises.Sort();
    return paises.GetEnumerator();
  }
*/


class Pais : IComparable<Pais>{
  private string nome;
  private int ouro, prata, bronze;
  public Pais(string n, int o, int p, int b){
    this.nome = n;
    this.ouro = o;
    this.prata = p;
    this.bronze = b;
  }
  public int CompareTo(Pais obj){
    Pais x = this;
    Pais y = (Pais) obj;
    if(x.ouro != y.ouro) return y.ouro.CompareTo(x.ouro);
    else if(x.ouro == y.ouro && x.prata != y.prata) return y.prata.CompareTo(x.prata);
    else if(x.ouro == y.ouro && x.prata == y.prata && x.bronze != y.bronze) return y.bronze.CompareTo(x.bronze);
    else return -y.nome.CompareTo(x.nome);
  }
  public override string ToString(){
    return $"{nome}\nOuro: {ouro}\nPrata: {prata}\nBronze: {bronze}\n";
  }

}
