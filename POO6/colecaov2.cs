using System;

class MainClass{
  public static void main(string[] args){

  }
}

class Colecao{
  private object[] itens;
  private int max = 0;
  public Colecao(int max){
    if(max > 0) this.max = max;
    this.itens = new object[max];
  }
  public void Inserir(object item){
      this.itens[max] = item;
      max++;
    }
  }
  public object Listar(){
    for(int j = 0; j < max; j++){
      return itens[j];
    }
  }
  public int NumItens(){
    return this.max;
  }
}