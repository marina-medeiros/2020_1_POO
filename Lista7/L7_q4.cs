using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Escreva dois valores,um em cada linha.");
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine($"O MMC deles é {MMC(x, y)}");
  }

  public static int MMC(int a, int b){
    int c = a * b;
    int y = 0;
    for(int i = 0; i <= c; i++){
      y = a * i;
      if (y % b == 0){
        y = y;
      }
    }
    return y;
  }
}