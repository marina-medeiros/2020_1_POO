using System;

class MainClass {
  public static void Main (string[] args) {
    Bingo b = new Bingo();
    b.Iniciar(10);
    Console.WriteLine("1-Nova bola, 2-Fim do Jogo");
    int op = int.Parse(Console.ReadLine());
    while (op != 2) {
      Console.WriteLine("Bola sorteada = " + b.Proximo());
      op = int.Parse(Console.ReadLine());
    }
    foreach(int bola in b.Sorteados())
      Console.WriteLine(bola);
  }
}

class Bingo{
  private int numBolas;
  private int[] Bolas;
  private int k;
  public void Iniciar(int numBolas){
    if (numBolas > 0){
      this.numBolas = numBolas;
      Bolas = new int[numBolas];
      k = 0;
    }
  }
 public int Proximo(){
    if (k == numBolas) return -1;
    Random r = new Random();
    int x = r.Next(1, numBolas);
    int p = Array.IndexOf(Bolas, x);
    while (p != -1) {
      x = r.Next(1, numBolas + 1);
      p = Array.IndexOf(Bolas, x);
    }
    Bolas[k] = x;
    k++;
    return x;
  }
  public int[] Sorteados(){
    return Bolas;
  }
}