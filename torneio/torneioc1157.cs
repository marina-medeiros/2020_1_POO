using System;

class MainClass {
  public static void Main (string[] args) {
  int a = int.Parse(Console.ReadLine());
  int aux = 1;
    while (a >= aux){
      if (a % aux == 0){
        Console.WriteLine(aux);
      }
    aux++;
    }
  }
}