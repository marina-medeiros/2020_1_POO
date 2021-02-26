using System;

class MainClass {
  public static void Main (string[] args){
    double a = double.Parse(Console.ReadLine());
    if (a >= 0 && a <= 25)
      Console.WriteLine("Intervalo [0,25]");
      if (a > 25 && a <= 50)
        Console.WriteLine("Intervalo (25,50]");
        if (a > 50 && a <= 75)
          Console.WriteLine("Intervalo (50,75]");
          if (a > 75 && a <= 100)
            Console.WriteLine("Intervalo (75,100]");
            else
              Console.WriteLine("Fora de intervalo");
  }
}