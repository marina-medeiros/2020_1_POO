using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Questão 03");
    double x = 4.3;
    int y;
    int z;
    Intervalo(x, out y, out z);
    Console.WriteLine(y);
    Console.WriteLine(z);
    // Exemplo de Parse
    Console.WriteLine("Digite um valor");
    int v = 0;
    while (int.TryParse(Console.ReadLine(), out v) == false)
      Console.WriteLine("Valor informado não é um inteiro. Digite novamente!");
    Console.WriteLine(v);
  }

  public static void Intervalo(double x, out int inicio, out int fim)
  {
    // 4.3 -> 4
    // 4.0 -> 4
    inicio = (int) x;
    fim = inicio + 1;
  }