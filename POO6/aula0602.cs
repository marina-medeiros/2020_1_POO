using System;

class MainClass{
  public static void Main(string[] args){
    Time time = new Time("ABC");
    Jogador j1 = new Jogador("Zaze", 10);
    Jogador j2 = new Jogador("Zezé", 11);
    Jogador j3 = new Jogador("Zizi", 12); 
    time.Inserir(j1);
    time.Inserir(j2);
    time.Inserir(j3);
    foreach(Jogador x in time.Listar())
      Console.WriteLine(x);
  }
}

class Jogador{
  private string nome;
  private int camisa;
  public Jogador(string nome, int camisa){
    this.nome = nome;
    this.camisa = camisa;
  }
  public override string ToString(){
    return $"{nome} {camisa}";
  }
}

class Time{
  private string nome;
  private Jogador[] jogs;
  private int k;
  public Time(string nome){
    this.nome = nome;
    jogs = new Jogador[6];
    // dava pra botar isso la em cima também
    // todos ficam com null no inicio pq é uma classe e classes são tipos por referência
  }
  public void Inserir(Jogador jog){
    if(k < 6){
      jogs[k] = jog;
      k++;
    }
  }
  public Jogador[] Listar() {
    // retorna um vetor com a quantidade de jogadores inseridos no time
    Jogador[] r = new Jogador[k];
    //vetor de origem, vetor de destino, elementos copiados:
    Array.Copy(jogs, r, k);
    return r;
  }

}