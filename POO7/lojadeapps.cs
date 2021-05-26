using System;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Loja AppStore = new Loja();
    Aplicativo Zap = new Aplicativo {Nome = "Zap", Categoria = "Rede Social", Preco = Convert.ToDecimal(10)};
    Aplicativo Clash = new Aplicativo {Nome = "Clash", Categoria = "Jogo", Preco = Convert.ToDecimal(50)};
    Aplicativo Fb = new Aplicativo {Nome = "Face", Categoria = "Rede Social", Preco = Convert.ToDecimal(70)};
    AppStore.Inserir(Zap);
    AppStore.Inserir(Fb);
    AppStore.Inserir(Clash);
    Zap.Curtir();
    Zap.Curtir();
    Clash.Curtir();
    Console.WriteLine("Redes sociais:");
    foreach(Aplicativo x in AppStore.Pesquisar("Rede Social"))
      Console.WriteLine(x);
    Console.WriteLine("Excluindo FaceBook da loja");
    AppStore.Excluir(Fb);
    foreach(Aplicativo x in AppStore.Listar())
      Console.WriteLine(x);
  }
}
class Loja{
  private Aplicativo[] apps;
  private int k = 0;
  public Loja(){
    this.apps = new Aplicativo[k];
  }
  public string Nome {
    set {if(value.Length > 0) Nome = value;}
    get {return Nome;}
  }
  public int Qtd{
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
    return apps;
  }
  public Aplicativo[] Pesquisar(string cat){
    Aplicativo[] lista = new Aplicativo[apps.Length];
    for(int i = 0; i < apps.Length; i++){
      if(apps[i].Categoria == cat){
        lista[i] = apps[i];
      }
    }
    return lista;
  }
  
}
class Aplicativo{
  private int curtidas;
  public string Nome {get; set;}
  public string Categoria {get; set;}
  public decimal Preco {get; set;}
  public int Curtidas {
    get {return curtidas;}
  }
  public void Curtir(){
    curtidas++;
  }
  public override string ToString(){
    return $"Nome: {Nome}\nCategoria: {Categoria}\nPreço: {Preco}\nCurtidas: {Curtidas}\n";
  }
}