using System;

class MainClass {
  public static void Main (string[] args){
    string[] ent = Console.ReadLine().Split(' ');
    int n1,n2,n3,n4,n5;
    n1 = int.Parse(ent[0]); n2 = int.Parse(ent[1]); n3 = int.Parse(ent[2]); n4 = int.Parse(ent[3]); n5 = int.Parse(ent[4]);

    if ( n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5)
    {
      Console.WriteLine('C');
    }
      else if ( n1 > n2 && n2 > n3 && n3 > n4 && n4 > n5)
      {
        Console.WriteLine('D');
      }
    else{
      Console.WriteLine('N');
    }
  }
}
