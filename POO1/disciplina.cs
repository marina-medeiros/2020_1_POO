using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Qual é o nome da disciplina?");
    string disciplina = Console.ReadLine();
    Console.WriteLine("Escreva as médias");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    double mm = Calculos.MediaParcial(a, b, c, d);
      Console.WriteLine($"Sua média em {disciplina} é {mm}");
    if (mm < 60){
      int notaRec = int.Parse(Console.ReadLine());
      double mf = Calculos.Rec(notaRec, mm);
      Console.WriteLine($"Sua média parcial em {disciplina} é {mm} e sua média final é {mf}");
    }


  }
}

class Calculos {
  public static double MediaParcial(int n1, int n2, int n3, int n4) {
    double media =((n1 * 2) + (n2 * 2) + (n3 * 3) + (n4 * 3)) / 10;
    return media;
  }
  public static double Rec(int a, double b) {
    double rec = (a + b) / 2;
    return rec;
  }

}