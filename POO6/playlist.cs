using System;
class MainClass {
  public static void Main(string[] args){
    PlayList p = new PlayList("Cavetown", "As melhores do cavetown");
    Musica mus1 = new Musica("Deviltown", "Cavetown", "Deviltown", DateTime.Now, new TimeSpan(0, 01, 57));
    p.Inserir(mus1);
    Musica mus2 = new Musica("LemonBoy", "Cavetown", "LemonBoy", DateTime.Now, new TimeSpan(0, 03, 22));
    p.Inserir(mus2);
    Musica mus3 = new Musica("Sweeth Tooth", "Cavetown", "SleepyHead", DateTime.Now, new TimeSpan(0, 03, 27));
    p.Inserir(mus3);
    Musica mus4 = new Musica("Feb 14", "Cavetown", "SleepyHead", DateTime.Now, new TimeSpan(0, 02, 57));
    p.Inserir(mus4);

    Console.WriteLine(p.ToString());
    Console.WriteLine(mus1.ToString());
    Console.WriteLine(p);
    
    foreach(Musica x in p.Listar());
      Console.WriteLine(x);
    
  }
}

class PlayList{
  private string nome;
  private string descricao;
  private int aux = 1;
  private Musica[] musicas;

  public PlayList(string nome, string descricao){
    if(nome.Length > 0) this.nome = nome;
    if(descricao.Length > 0) this.descricao = descricao;
    this.musicas = new Musica[0];
  }
  public void Inserir(Musica m){
    musicas = new Musica[aux];
    musicas[aux - 1] = m;
    aux++;
  }
  public string Listar(){
    string lista = $"Playlist {nome} = ";
    for(int j = 0; j < musicas.Length; j++){
      if(j != musicas.Length - 1) lista += musicas[j].getTitulo() + ",";
      else lista = musicas[j].getTitulo() + ".";
    }
    return lista;
  }
  public TimeSpan TempoTotal(){
    TimeSpan tempo = musicas[0].getDuracao();
    for (int i = 0; i < aux; i++){
      tempo = tempo + musicas[i].getDuracao();
    }
    return tempo;
  }
  public override string ToString(){
    return $"PLAYLIST: {nome} - {descricao}";
  }
}

class Musica{
  private string titulo;
  private string artista;
  private string album;
  private DateTime dataInclusao;
  private TimeSpan duracao;

  public Musica(string titulo, string artista, string album, DateTime dataInclusao, TimeSpan duracao){
    if(titulo.Length > 0) this.titulo = titulo;
    if(artista.Length > 0) this.artista = artista;
    if(album.Length > 0) this.album = album;
    this.dataInclusao = dataInclusao;
    this.duracao = duracao;
  }
  public string getTitulo() {
    return this.titulo;
  }
  public string getArtista() {
    return this.artista;
  }
  public string getAlbum() {
    return this.album;
  }
  public DateTime getData() {
    return this.dataInclusao;
  }
  public TimeSpan getDuracao() {
    return this.duracao;
  }
  public override string ToString(){
    return $"Música: {artista} - {titulo} ({album}). Duração: {duracao}\nInserida em {dataInclusao}";
  }
}

