using System;
using System.Collections;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    ISequencia f = new Fibonacci();
    ISequencia p = new PA();
    Console.WriteLine("Fibonacci");
    for(int i = 0; i < 11; i++){
      Console.WriteLine(f.Proximo());
    }
    Console.WriteLine("PA:");
    for(int i = 0; i < 11; i++){
      Console.WriteLine(p.Proximo());
    }
  }
}

class Fibonacci : ISequencia{
  private int inicio, c;
  private int a = 0;
  private int b = 1;
  private int aux = 0;
  public int Iniciar(){
    inicio = 0;
    return inicio;
  }
  public int Proximo(){
   if (aux == 0){
     aux++; // aux = 1
     return 0;
   }
   if (aux == 1){
     aux++;
     return 1; // 1
   }
    else{
      c = a + b;
      a = b;
      b = c;
      return c;
    }
  }
}

/*
a = 0;
    b = 1;
    c = a + b; // c = 0 + 1 = 1
    a = b + c; // a = 1 + 1 = 2
    b = c + a; // b = 1 + 2 = 3
    c = a + b; // c = 2 + 3 = 5

    //0, 1, 1c, 2, 3, 5c, 8, 13, 21c
*/


class PA : ISequencia{
  private int primeiroElemento = 1;
  private int razao = 2;
  private int proximo = 0;
  public int Iniciar(){
    return primeiroElemento;
  }
  public int Proximo(){
    proximo = primeiroElemento + razao; // 3 , 5, 7
    primeiroElemento = primeiroElemento + razao; //3
    return proximo;
  }
}

interface ISequencia{
  int Iniciar();
  int Proximo();
}
