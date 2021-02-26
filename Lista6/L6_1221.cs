using System;

class MainClass {
  public static void Main (string[] args){
    int n = int.Parse(Console.ReadLine());
    int a = 1;
    int b = 0;
    
    while (a <= n && b < 4){
      if (n % a == 0){
        b = b + 1;
        a = a + 1;
      }
    }

    if (b < 3){
      Console.WriteLine("Primo");
    }
    else Console.WriteLine("Não primo");

  }
}
