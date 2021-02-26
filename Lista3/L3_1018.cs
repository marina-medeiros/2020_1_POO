using System;

class MainClass {
  public static void Main (string[] args) {
   int a = int.Parse(Console.ReadLine());
   int ori = a;
   int cem=0, cinquenta=0, vinte=0, dez=0, cinco=0, dois=0, um=0;

  if (a / 100 >= 1)
    cem = a / 100 ; a %= 100;
  if (a / 50 >= 1)
    cinquenta = a / 50 ; a %= 50;
  if (a / 20 >= 1)
    vinte = a / 20 ; a %= 20;
  if (a / 10 >= 1)
    dez = a / 10 ; a %= 10;
  if (a / 5 >= 1)
    cinco = a / 5 ; a %= 5;
  if (a / 2 >= 1)
    dois = a / 2 ; a %= 2;
  if (a / 1 >=1)
    um = a / 1 ; a %= 1;

  Console.WriteLine($"{ori}");
  Console.WriteLine($"{cem} nota(s) de R$ 100,00");
  Console.WriteLine($"{cinquenta} nota(s) de R$ 50,00");
  Console.WriteLine($"{vinte} nota(s) de R$ 20,00");
  Console.WriteLine($"{dez} nota(s) de R$ 10,00");
  Console.WriteLine($"{cinco} nota(s) de R$ 5,00");
  Console.WriteLine($"{dois} nota(s) de R$ 2,00");
  Console.WriteLine($"{um} nota(s) de R$ 1,00");
  }
}