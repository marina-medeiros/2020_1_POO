using System;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Agenda agenda = new Agenda();
    Compromisso aniv = new Compromisso{ Assunto = "Aniversário de Lis", Local = "Currais Novos", Data = new DateTime(2022, 01, 02)};
    Compromisso aula = new Compromisso{ Assunto = "Aula", Local = "Escola", Data = new DateTime(2022, 01, 01)};
    Compromisso show = new Compromisso{ Assunto = "Show de rock", Local = "Estádio", Data = new DateTime(2022, 05, 01)};
    agenda.Inserir(aniv);
    agenda.Inserir(aula);
    agenda.Inserir(show);
    agenda.Excluir(aula);
    foreach(Compromisso x in agenda.Pesquisar(01,2022))
      Console.WriteLine(x);
    //Console.WriteLine(agenda.Pesquisar(01, 2022));
    //Console.WriteLine(agenda.Listar());
    Console.WriteLine("xxx");
    foreach(Compromisso x in agenda.Listar())
      Console.WriteLine(x);
  }
}
class Agenda{
  private Compromisso[] comps;
  private int k = 0;
  public int Qtd {
    get {return k;}
  }
  public Agenda(){
    this.comps = new Compromisso[0];
  }
  public void Inserir(Compromisso c){
    if(k == comps.Length) {
      Array.Resize(ref comps, k + 1);
      comps[k] = c;
      k++;
    }
  }
  public void Excluir(Compromisso c){
    int index = Array.IndexOf(comps, c);
    comps = comps.Where((e, i) => i != index).ToArray();
  }
    /*
      public static void Main()
          {
              int[] array = { 1, 3, 4, 5, 4, 2 };
              int item = 4;
      
              int index = Array.IndexOf(array, item);
              array = array.Where((e, i) => i != index).ToArray();
      
              Console.WriteLine(String.Join(",", array));
          }

        List<int> list = myArray.ToList();
        int value = list[1];
        list.RemoveAt(1);
        list.Add(value);
        myArray = list.ToArray();

        List<Compromisso[]> list = comps.ToList();
        list.RemoveAt(Array.IndexOf(comps, c));
        comps = list.ToArray();
    */
  public Compromisso[] Listar(){
    Compromisso[] lista = new Compromisso[comps.Length];
    for(int i = 0; i < comps.Length; i++){
      lista[i] = comps[i];
    }
    return lista;
  }

  public Compromisso[] Pesquisar(int mes, int ano){
    Compromisso[] numeroComp = new Compromisso[comps.Length];
    for(int i = 0; i < comps.Length; i++){
      if (comps[i].Data.Month == mes && comps[i].Data.Year == ano){
        numeroComp[i] = comps[i];
      }
    }
    return numeroComp; 
  }
}
class Compromisso{
  public string Assunto{ get; set;}
  public string Local{get; set;}
  public DateTime Data{get; set;}
  public override string ToString(){
    return $"Compromisso:\n'{Assunto}'\n{Local}\n{Data.ToString("dd/MM/yyyy")}\n";
  }
}