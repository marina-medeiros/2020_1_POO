using System;

class MainClass{
  public static void Main(string[] args){
    string[] ee = Console.ReadLine().Split(' ');
    int d = int.Parse(ee[0]);
    int vf = int.Parse(ee[1]);
    int vg = int.Parse(ee[2]);

    int aux= 0;
    int pf = vf + d;
    int pg= vg;

    while(pf < 12){
      aux++;
      pf= (vf * aux) + d;
      pg= vg * aux;
    }

    if (pf > pg){
      Console.WriteLine("S");
    }
    else Console.WriteLine("N");
  }
}
