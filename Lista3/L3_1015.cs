using System;

class MainClass {
  static void Main (string[] args) {
    string[] ent = Console.ReadLine().Split(' ');
    string[] ent2 = Console.ReadLine().Split(' ');
    double a1 = (int.Parse(ent[1]) - int.Parse(ent[2]));
    double a2 = (int.Parse(ent2[1]) - int.Parse(ent2[2]));
    double resp = Math.Sqrt((a1 * a1) + (a2 * a2));
    Console.WriteLine($"{resp}");
  }
}