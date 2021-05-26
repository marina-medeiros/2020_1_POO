using System;

class MainClass{
  public static void Main(string[] args){
    //string, inteiros e datas implementam a interface de comparação (outros tbm fazem isso)
    //quando um tipo implementa a interface de comparação, é possível ordenar os elementos de um vetor desse tipo usando o método sort da classe array
    int[] v = {2, 4, 6, 8 , 1, 3, 5, 7};
    Array.Sort(v);
    foreach(int i in v) Console.WriteLine(i);

    string[] w = {"C#", "Java", "Python", "Basic"};
    Array.Sort(w);
    foreach(string i in w) Console.WriteLine(i);

    DateTime[] x= {
      DateTime.Parse("2020-11-10"),
      DateTime.Parse("2019-11-10"),
      DateTime.Parse("2018-11-10"),
    };
    Array.Sort(x);
    foreach(DateTime i in x) Console.WriteLine(i);

    IComparable a = 10;
    IComparable b = 20;
    Console.WriteLine(b.CompareTo(10)); //1 (b > 10)
    Console.WriteLine(a.CompareTo(10)); //0 (a = 10)
    Console.WriteLine(b.CompareTo(a)); //1 (b > a)
    Console.WriteLine(a.CompareTo(b)); // -1 (a < b)
  }
}
