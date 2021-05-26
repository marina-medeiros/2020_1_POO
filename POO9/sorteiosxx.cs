using System;

class MainClass {
  public static void Main (string[] args) {
    Bingo b = new Bingo();
    b.Iniciar(10);

    for (int i = 0; i < 10; i++) {
      Console.WriteLine(b.Proximo());
    }
    
    Console.WriteLine ("Mega:");
    Mega m = new Mega();
    for (int i = 0; i < 10; i++) {
      m.Proximo();
    }

    foreach (int i in m.Sorteados()) {
      Console.WriteLine(i);
    }
    
  }
}

interface  ISorteio {
  int Proximo();
  int[] Sorteados();
}

class Bingo : ISorteio {
  private int numBolas;
  private int[] sorteados;
  private int k = 0;

  public void Iniciar(int n) {
    numBolas = n;
    sorteados = new int[n];
  }

  public int[] Sorteados() {
    int[] l = new int[k];
    Array.Copy(sorteados,l,k);
    return l;
  }
  //Sorteando bola
  public int Proximo() {
    if (k >= numBolas) {return -1;} else
    {
      Random rnd = new Random();
      int o = rnd.Next(1,numBolas+1);

      while (Array.IndexOf(sorteados,o) != -1)
      {
        o = rnd.Next(1,numBolas+1);
      }
      sorteados[k] = o;
      k++;
      return o;
    }
  }
}

class Mega : ISorteio {
  private int[] sorteados = new int[6];
  private int k = 0;

  public int[] Sorteados() {
    int[] l = new int[k];
    Array.Copy(sorteados,l,k);
    return l;
  }
  public int Proximo() {
    if (k >= 6) {
      return -1;
    } 
    else{
      Random rnd = new Random();
      int o = rnd.Next(1,60);
      while (Array.IndexOf(sorteados,o) != -1){
        o = rnd.Next(1,60);
      }
      sorteados[k] = o;
      k++;
      return o;
    }
  }
}