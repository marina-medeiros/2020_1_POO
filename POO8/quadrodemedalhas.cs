using System;

class MainClass{
  public static void Main(string[] args){
    QuadroMedalhas quadro = new QuadroMedalhas();
    Pais Argentina = new Pais("Argentina", 3, 1, 2);
    quadro.Inserir(Argentina);
    Pais Brasil = new Pais("Brasil", 0, 2, 2);
    quadro.Inserir(Brasil);
    Pais Coreia = new Pais("Coreia", 0, 2, 2);
    quadro.Inserir(Coreia);
    Pais Russia = new Pais("Russia", 3, 2, 2);
    quadro.Inserir(Russia);
    Pais Zimbabue = new Pais("Zimbabue", 3, 1, 2);
    quadro.Inserir(Zimbabue);
    foreach(Pais i in quadro.Listar()) Console.WriteLine(i.ToString());
  }
}

class QuadroMedalhas{
  private Pais[] paises;
  public int n = 0;
  public QuadroMedalhas(){
    this.paises = new Pais[0];
  }
  public void Inserir(Pais p){
    if(n == paises.Length){
      Array.Resize(ref paises, n + 1);
      paises[n] = p;
      n++;
    }
  }
  public Pais[] Listar(){
    Array.Sort(paises);
    return paises;
  }
}

class Pais : IComparable {
  private string nome;
  private int ouro, prata, bronze;
  public Pais(string n, int o, int p, int b){
    this.nome = n;
    this.ouro = o;
    this.prata = p;
    this.bronze = b;
  }
  public override string ToString(){
    return $"{nome}\nOuro: {ouro}\nPrata: {prata}\nBronze: {bronze}\n";
  }
  public int CompareTo(object obj){
    Pais x = this;
    Pais y = (Pais) obj;
    if(x.ouro != y.ouro) return y.ouro.CompareTo(x.ouro);
    else if(x.ouro == y.ouro && x.prata != y.prata) return y.prata.CompareTo(x.prata);
    else if(x.ouro == y.ouro && x.prata == y.prata && x.bronze != y.bronze) return y.bronze.CompareTo(x.bronze);
    else return -y.nome.CompareTo(x.nome);
  }
}