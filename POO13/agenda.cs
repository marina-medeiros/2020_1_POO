using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MainClass{
  public static void Main(string[] args){
    Agenda agenda = new Agenda();
    try{
      Compromisso a = new Compromisso("Festa", "Parque", new DateTime(2004, 02, 05));
      Compromisso b = new Compromisso("Aula", "Escola", new DateTime(2004, 02, 05));
      Compromisso c = new Compromisso("Show", "Estádio", new DateTime(2005, 03, 05));
      Compromisso d = new Compromisso("Show", "Estádio", new DateTime(2005, 03, 05));
      agenda.Inserir(a);
      agenda.Inserir(b);
      agenda.Inserir(c);
      agenda.Inserir(d); //erro
    }catch (InvalidOperationException){
      Console.WriteLine("o Compromisso ja foi inserido!");
    }
    foreach(Compromisso c in agenda.Listar()) Console.WriteLine(c);
  }
}

class Agenda {
  private List<Compromisso> comps = new List<Compromisso>();
  private int k;
  private int Qtd {get => k;}
  public void Inserir(Compromisso c){
    for(int i = 0; i < k; i++){
      if(comps[i].Assunto == c.Assunto && comps[i].Local == c.Local && comps[i].Data == c.Data){
        throw new InvalidOperationException("O Compromisso ja foi inserido");
      }
    }
    comps.Add(c);
    k++;
  }
  public void Excluir(Compromisso c){
    comps.Remove(c);
    k = k - 1;
  }
  public List<Compromisso> Listar(){
    return comps;
  }
  public List<Compromisso> Pesquisar (int mes, int ano){
    int aux = 0;
    List<Compromisso> pesq = new List<Compromisso>();
    for(int i = 0; i < comps.Count; i++){
      if(comps[i].Data.Month == mes && comps[i].Data.Year == ano){
        pesq.Add(comps[i]);
        aux++;
      }
    }
    if(aux == 0) Console.WriteLine("Sem compromissos");
    return pesq;
  }
}

class Compromisso {
  public string Assunto {get; set;}
  public string Local {get; set;}
  public DateTime Data {get; set;}
  public Compromisso(string a, string l, DateTime d){
    if(a.Length > 0) Assunto = a;
    if(l.Length > 0) Local = l;
    Data = d;
  }
  public override string ToString(){
    return $"{Assunto} {Local} {Data}";
  }
}