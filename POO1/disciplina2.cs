using System;

class MainClass {
  public static void Main (string[] args) {
    Media m = new Media();
    Console.WriteLine("Qual é o nome da disciplina?");
    string d = Console.ReadLine();
    Console.WriteLine("Digite as médias dos 4 bimestres.");
    m.n1 = int.Parse(Console.ReadLine());
    m.n2 = int.Parse(Console.ReadLine());
    m.n3 = int.Parse(Console.ReadLine());
    m.n4 = int.Parse(Console.ReadLine());
    if (m.media() < 60){
      Console.WriteLine("Digite a nota da prova final");
      m.pf = int.Parse(Console.ReadLine());
    }
    if (m.media() < 60) {
      Console.WriteLine($"Você foi reprovado em {d}. Sua média final foi {m.media()}");
    }
    if (m.media() >= 60) {
      Console.WriteLine($"Você foi aprovado em {d}. Sua média final foi {m.media()}");
    }
  }
}

class Media {
  public int n1, n2, n3, n4, pf;
  public int media() {
    int m1 =((n1 * 2) + (n2 * 2) + (n3 * 3) + (n4 * 3)) / 10;
    if (m1 < 60){
      m1 = (m1 + pf) / 2;
    }
    return m1;
  }
  

}