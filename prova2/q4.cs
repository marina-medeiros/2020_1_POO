using System;

class MainClass {
  public static void Main (string[] args) {
    int[] v = { 1, 2 , 3, 4, 5, 6, 7, 8};
    int[] p = { 1, 7 , 3, 5, 6, 2, 0, 4};
    int soma = 0;
    foreach (int i in p) {
      if(i % 2 == 1) {
        soma += v[i];
      }
    }
    Console.WriteLine(soma);

  }
}