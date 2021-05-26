using System;
using System.Collections;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Bingo b = new Bingo();
    b.Iniciar(10);
    for(int i = 0; i < 10; i++){
      b.Proximo();
    }
    Console.WriteLine("Numeros do bingo:");
    foreach(int q in b.Sorteados()) Console.WriteLine(q);

    Mega m = new Mega();
    m.Iniciar();
    for(int i = 0; i < 6; i++){
      m.Proximo();
    }
    Console.WriteLine("Numeros da loteria:");
    foreach(int a in m.Sorteados()) Console.WriteLine(a);
  }
}

class Bingo : ISorteio{
  private int numBolas, aux;
  private int[] bolasSorteadas;
  public void Iniciar(int numBolas){
    this.numBolas = numBolas;
    this.bolasSorteadas = new int[numBolas];
  }
  public int Proximo(){
    if(aux >= numBolas){
      return -1;
    }else{
      Random r = new Random();
      int p = r.Next(0, numBolas+1);
      while(Array.IndexOf(bolasSorteadas, p) != -1){
        p = r.Next(0, numBolas+1);
      }
      bolasSorteadas[aux] = p;
      aux++;
      return p;
    }
  }
  public int[] Sorteados(){
    int[] w = new int[aux];
    Array.Copy(bolasSorteadas,w,aux);
    return w;
  }
}

/*
  Random x = new Random();
  int bola = x.Next(1, numBolas + 1);
*/

class Mega : ISorteio{
  private int aux;
  private int[] numsSorteados;
  public void Iniciar(){
    this.numsSorteados = new int[6];
  }
  public int Proximo(){
    if(aux >= 6){
      return -1;
    }else{
      Random r = new Random();
      int p = r.Next(0, 60);
      while(Array.IndexOf(numsSorteados, p) != -1){
        p = r.Next(0, 60);
      }
      numsSorteados[aux] = p;
      aux++;
      return p;
    }
  }
  public int[] Sorteados(){
    int[] v = new int[aux];
    Array.Copy(numsSorteados,v,aux);
    return v;
  }
}

interface ISorteio{
  int Proximo();
  int[] Sorteados();
}

