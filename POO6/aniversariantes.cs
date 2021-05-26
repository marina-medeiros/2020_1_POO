using System;

class MainClass{
  public static void Main(string[] args){
    Agenda a = new Agenda();
    Contato marina = new Contato("Marina", "91234-5678", new DateTime(2004, 02, 05));
    a.Inserir(marina);
    Contato nanda = new Contato("Nanda", "91111-2222", new DateTime (2000, 10, 19));
    a.Inserir(nanda);
    Contato arlindo = new Contato("Arlindo", "92233-4444", new DateTime(1992, 10, 10));
    a.Inserir(arlindo);
    Console.WriteLine(marina);
    Console.WriteLine(marina.ToString());
    Console.WriteLine("xxx");
    foreach(Contato x in a.AniversariantesMes(10))
      Console.WriteLine(x);
  }
}

class Agenda{
  private Contato[] contatos;
  private int aux;
  public void Inserir(Contato c){
    aux = 1;
    contatos = new Contato[aux];
    contatos[aux-1] = c;
    aux++;
  }
  public Contato[] Listar(){
    return contatos;
  }
  public Contato[] AniversariantesMes(int mes){
    Contato[] aniversariantes = new Contato[contatos.Length];
    for(int i = 0; i < contatos.Length; i++){
      if(contatos[i].getData().Month == mes){
          aniversariantes[i] = contatos[i];
      }
    }
    return aniversariantes;
  }
}


class Contato{
  private string nome, telefone;
  private DateTime nascimento;
  public Contato(string n, string t, DateTime nasc){
    if(n.Length > 0) this.nome = n;
    if(t.Length > 0) this.telefone = t;
    this.nascimento = nasc;
  }
  public string getNome(){
    return nome;
  }
  public DateTime getData(){
    return nascimento;
  }
  public override string ToString(){
    return $"Contato: {nome} - {telefone} - {nascimento}";
  }
}