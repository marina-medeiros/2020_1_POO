using System;

public class MainClass {
  public static void Main (string[] args){
    Console.Wr
  }
}

public class Dado {
  int lados = 6;
  int valor = 1;
  public void rolar() {

  }
  public int GetLados(){
    return lados;
  }
  public void SetLados(int lados){
    if(lados > 0 && lados % 3 == 0) this.lados = lados;
  }
  public int GetValor(){
    valor = lados;
  }

}