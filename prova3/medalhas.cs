using System;
using System.Collections;

class MainClass {
  public static void Main (string[] args) {
    QuadroMedalhas qm = new QuadroMedalhas();
    Pais p1 = new Pais("Brasil",1,3,3);
    Pais p2 = new Pais("Argentina",2,3,1);
    Pais p3 = new Pais("Alemanha",3,1,2);
    qm.Inserir(p1);
    qm.Inserir(p2);
    qm.Inserir(p3);
    Pais[] v = qm.Listar();

    foreach (Pais i in v) {
      Console.WriteLine (i);
    }
  }
}

class QuadroMedalhas {
  private Pais[] paises = new Pais[32];
  private int k = 0;

  public void Inserir(Pais p) {
    if (k < 32) {paises[k++] = p;}
  }

  public Pais[] Listar() {
    Pais[] l = new Pais[k];
    Array.Copy(paises,l,k);
    Array.Sort(l);
    return l;
  }
}

class Pais : IComparable {
  private string nome;
  private int ouro, prata, bronze;

  public int Ouro {get => ouro;}
  public int Prata {get => prata;}
  public int Bronze {get => bronze;}
  public string Nome {get => nome;}

  public Pais(string n, int o, int p, int b) {
    nome = n;
    ouro = o;
    prata = p;
    bronze = b;
  }

  public int CompareTo(object obj) {
    Pais ob = (Pais) obj;
    if (Ouro != ob.Ouro) {
      return -Ouro.CompareTo(ob.Ouro);
    } 
    else if (Prata != ob.Prata) {
      return -Prata.CompareTo(ob.Prata);
    } 
    else if (Bronze != ob.Bronze) {
      return -Bronze.CompareTo(ob.Bronze);
    } 
    else
    {return Nome.CompareTo(ob.Nome);}
  }

  public override string ToString() {
    return $"{nome}, Ouro: {ouro}, Prata: {prata}, Bronze: {bronze}";
  }
}