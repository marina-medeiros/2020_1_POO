using System;
class MainClass {
  public static int func(int x) {
    if (x % 2 == 0) return x * x + 1;
    return x * 2;
  }
  public static void Main (string[] args){
    int x = 3;
    Console.Write($"{func(x)} - ");
    x++;
    Console.Write($"{func(x)} - ");
    x-=2;
    Console.Write($"{func(func(x))}");
  }
}
