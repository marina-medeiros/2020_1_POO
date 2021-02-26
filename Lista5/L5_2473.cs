using System;

class MainClass{
  public static void Main (string[] args){
    string[] ap = Console.ReadLine().Split(' ');
    string[] st = Console.ReadLine().Split(' ');
    int aux = 0;

    for (int i = 0; i < 6; i++){
      if (ap[0] == st[i]) aux++;
        else if (ap [1] == st[i]) aux++;
        else if (ap [2] == st[i]) aux++;
        else if (ap [3] == st[i]) aux++;
        else if (ap [4] == st[i]) aux++;
        else if (ap [5] == st[i]) aux++;
    }

    string [] certo = {"azar", "azar", "azar", "terno", "quadra", "quina", "sena"};
    Console.WriteLine($"{certo[aux]}");
  }
}