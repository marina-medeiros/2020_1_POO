using System;

class MainClass{
  public static void Main(string[] args){
    Colecao c = new Colecao(3);
    c.Inserir("item1");
    c.Inserir("item2");
    c.Inserir("item3");
    Console.WriteLine("aaaa");
    Console.WriteLine(c.Listar());
  }
}

class Colecao{
  private object[] itens;
  private int max;
  private object itensArray = "Itens = ";
  public Colecao(int max){
    if(max > 0)this.max = max;
    this.itens = new object[max];
  }
  public void Inserir(object item){
    for(int i = 0; i < max; i++){
      itens[i] = item;
    }
  }
  public object Listar(){
    for (int i = 0; i < max; i++) {
      if (i != max - 1) itensArray += itens[i] + ", ";
        else itensArray += itens[i] + ".";
      }
    return this.itensArray;
  }
  public int NumItens(){
    return this.max;
  }
}
