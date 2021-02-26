using System;

class MainClass {
  public static void Main (string[] args) {
    int x = 6; int y = 10;
    while (x != y){
      if (x > y) x = x - y;
      else       y = y - x;
    }
    Console.WriteLine (x);
  }
}