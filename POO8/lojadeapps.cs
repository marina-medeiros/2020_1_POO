using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class MainClass{
  public static void Main (string[] args){
    Aplicativo Zap = new Aplicativo {Nome = "Zap", Categoria = "Rede Social", Preco = Convert.ToDecimal(10), Curtidas = 10};
    Aplicativo Clash = new Aplicativo {Nome = "Clash", Categoria = "Jogo", Preco = Convert.ToDecimal(50), Curtidas = 15};
    Aplicativo Fb = new Aplicativo {Nome = "Face", Categoria = "Rede Social", Preco = Convert.ToDecimal(70), Curtidas = 2};
    Aplicativo Tt = new Aplicativo {Nome = "Twitter", Categoria = "Rede Social", Preco = Convert.ToDecimal(70), Curtidas = 4};

    Aplicativo a = new Aplicativo {Nome = "a", Categoria = "Rede Social", Preco = Convert.ToDecimal(4), Curtidas = 160};
    Aplicativo b = new Aplicativo {Nome = "b", Categoria = "Jogo", Preco = Convert.ToDecimal(55), Curtidas = 16};
    Aplicativo c = new Aplicativo {Nome = "c", Categoria = "Utilidades", Preco = Convert.ToDecimal(2), Curtidas = 888};
    Aplicativo d = new Aplicativo {Nome = "d", Categoria = "Utilidades", Preco = Convert.ToDecimal(222), Curtidas = 4};
    Aplicativo e = new Aplicativo {Nome = "e", Categoria = "Rede Social", Preco = Convert.ToDecimal(1), Curtidas = 101};
    Aplicativo f = new Aplicativo {Nome = "f", Categoria = "Jogo", Preco = Convert.ToDecimal(56), Curtidas = 5};
    Aplicativo g = new Aplicativo {Nome = "g", Categoria = "Utilidades", Preco = Convert.ToDecimal(10), Curtidas = 22};

    Loja AppStore = new Loja{Nome = "AppStore"};
    AppStore.Inserir(Zap);
    AppStore.Inserir(Clash);
    AppStore.Inserir(Fb);
    AppStore.Inserir(Tt);
    AppStore.Inserir(a);
    AppStore.Inserir(b);
    AppStore.Inserir(c);
    AppStore.Inserir(d);
    AppStore.Excluir(e);
    AppStore.Inserir(f);
    AppStore.Inserir(g);

    
    Console.WriteLine("Todos os apps:");
    foreach(Aplicativo x in AppStore.Listar()) Console.WriteLine(x);
  
    Console.WriteLine("REDES SOCIAIS");
    foreach(Aplicativo x in AppStore.Pesquisar("Rede Social")) Console.WriteLine(x);
    Console.WriteLine("UTILIDADES");
    foreach(Aplicativo x in AppStore.Pesquisar("Utilidades")) Console.WriteLine(x);
    Console.WriteLine("TOP 10 MAIS CURTIDOS");
    foreach(Aplicativo x in AppStore.Top10MaisCurtidos()) Console.WriteLine(x);
    Console.WriteLine("MENOR PREÇO");
    foreach(Aplicativo x in AppStore.ListarPreco()) Console.WriteLine(x);
  
  }
}

class Loja {
  private Aplicativo[] apps;
  private int k = 0;
  public Loja(){
    this.apps = new Aplicativo[k];
  }
  public string Nome{
    get;
    set;
  }
  public int Qtd {
    get {return k;}
  }
  public void Inserir(Aplicativo app){
    if(k == apps.Length){
      Array.Resize(ref apps, k + 1);
      apps[k] = app;
      k++;
    }
  }
  public void Excluir(Aplicativo app){
    int index = Array.IndexOf(apps, app);
    apps = apps.Where((e, i) => i != index).ToArray();
  }
  public Aplicativo[] Listar(){
    Array.Sort(apps);
    return apps;
  }
  public Aplicativo[] Pesquisar(string cat){
    int aux = 0;
    for(int i = 0; i < apps.Length; i++){
      if(apps[i].Categoria == cat){
        aux++;
      }
    }
    Aplicativo[] pesq = new Aplicativo[aux];
    aux= 0 ;
    for(int j = 0; j < apps.Length; j++){
      if(apps[j].Categoria == cat){
        pesq[aux] = apps[j];
        aux++;
      }
    }
    return pesq;
  }

  public Aplicativo[] ListarPreco(){
    Array.Sort(apps, new PrecoComp());
    return apps;
  }
  public Aplicativo[] Top10MaisCurtidos(){
    Array.Sort(apps, new CurtidasComp());
    if (apps.Length > 10){
      Array.Resize(ref apps, 10);
    }
    return apps;
  }
}

class Aplicativo : IComparable {
  private int curtidas;
  public string Nome {get; set;}
  public string Categoria {get; set;}
  public decimal Preco {get; set;}
  public int Curtidas {
    set {curtidas = value;}
    get {return curtidas;}
  }
  public void Curtir(){
    Curtidas++;
  }
  public int CompareTo(object obj){
    Aplicativo a = (Aplicativo) obj;
    return this.Nome.CompareTo(a.Nome);
  }
  public override string ToString(){
    return $"App: {Nome} - {Categoria} Preco: {Preco} Curtidas: {Curtidas}\n";
  }
}

class PrecoComp : IComparer{
  public int Compare(object x, object y){
    Aplicativo a = (Aplicativo)x;
    Aplicativo b = (Aplicativo)y;
    return a.Preco.CompareTo(b.Preco);
  }
}

class CurtidasComp : IComparer{
  public int Compare(object x, object y){
    Aplicativo a = (Aplicativo)x;
    Aplicativo b = (Aplicativo)y;
    return -a.Curtidas.CompareTo(b.Curtidas);
  }
}
