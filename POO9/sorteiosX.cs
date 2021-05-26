using System;

class MainClass {
  public static void Main (string[] args) {

    //Criar instância
    Bingo b = new Bingo();
    b.Iniciar(10);

    //'Proximo' sortea um número ainda não sorteado
    for (int i = 0; i < 10; i++) {

      //Escrever número sorteado
      Console.WriteLine(b.Proximo());
    }

    //MEGA
    Console.WriteLine ("Mega:");

    //Criar instância
    Mega m = new Mega();


    for (int i = 0; i < 10; i++) {
      m.Proximo();
    }

    foreach (int i in m.Sorteados()) {
      Console.WriteLine(i);
    }
    
  }
}

interface  ISorteio {
  int Proximo();
  int[] Sorteados();
}

class Bingo : ISorteio {

  //Atributos
  private int numBolas;
  private int[] sorteados;
  private int k = 0;

  //Método para escolher a quantidade de bolas e inicar sorteio
  public void Iniciar(int n) {
    numBolas = n;
    sorteados = new int[n];
  }

  //Lista de bolas já sorteadas
  public int[] Sorteados() {
    int[] l = new int[k];
    Array.Copy(sorteados,l,k);
    return l;
  }

  //Sorteando bola
  public int Proximo() {

    //Retornando '-1' (quando todos os valores já tiverem sido sorteados)
    if (k >= numBolas) {return -1;} 
    
    //Caso ainda tenha bolas sobrando
    else
    {
      //Escolher um número aleatório
      Random rnd = new Random();
      int o = rnd.Next(1,numBolas+1);

      //Se o número aleatório já tiver sido escolhido, escolher outro
      while (Array.IndexOf(sorteados,o) != -1)
      {
        o = rnd.Next(1,numBolas+1);
      }

      //Adicionar número escolhido na lista de sorteados
      sorteados[k] = o;

      //Ir para próximo elemento da lista
      k++;

      //Retornar valor sorteado
      return o;
    }
  }
}

class Mega : ISorteio {

  //Atributos
  private int numBolas;
  private int[] sorteados = new int[6];
  private int k = 0;

  //Lista de números já sorteados
  public int[] Sorteados() {
    int[] l = new int[k];
    Array.Copy(sorteados,l,k);
    return l;
  }
  //Sorteando bola
  public int Proximo() {

    //Retornando '-1' (Catso todos os valores já tenham sido sorteados)
    if (k >= 6) {return -1;} else
    {
      //Escolher um número aleatório entre 1 e 60
      Random rnd = new Random();
      int o = rnd.Next(1,60);

      //Se o número aleatório já tiver sido escolhido, escolher outro
      while (Array.IndexOf(sorteados,o) != -1)
      {
        o = rnd.Next(1,60);
      }

      //Adicionar número escolhido na lista de sorteados
      sorteados[k] = o;

      //Ir para próximo elemento da lista
      k++;

      //Retornar valor sorteado
      return o;
    }
  }
}