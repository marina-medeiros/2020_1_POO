using System;
class Program {
  public static int MaiorA(string x) {
    int maior = int.Parse(x[0].ToString());
    for(int i = 1; i < x.Length; i++) {
        if (int.Parse(x[i].ToString()) > maior) maior = int.Parse(x[i].ToString());
    }
    return maior;
  }
  public static void Main(string[] args) {
    string x = Console.ReadLine();
    while(x != "0") {
        Console.WriteLine($"Maior algarismo = {MaiorA(x)}");
        x = Console.ReadLine();
    }
  }
}
  