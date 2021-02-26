using System;

class MainClass {
  public static void Main (string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int soma = 0;

    if(a < b){
      for (int i = a; i <= b; i++){
        if (i % 13 != 0) soma = soma + i;
      }
    }
    if (a > b){
      for(int i = b; i <= a;  i++){
        if (i % 13 != 0) soma = soma +i;
      }
    }
    if(a == b) soma = 0;

    Console.WriteLine($"{soma}");
  }
}