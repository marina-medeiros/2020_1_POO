using System;

public class MainClass {
  public static void Main() {
    Playlist p = new Playlist();
    Musica m1 = new Musica("Teenage Dirtbag", "Wheatus", "04:02");
    p.InserirMusica(m1);
    Musica m2 = new Musica("Meu Lugar", "Arlindo Cruz", "04:28");
    p.InserirMusica(m2);
    Console.WriteLine(p.GetTempoTotal());
  }
}

public class Musica {
  public string nome;
  public string artista;
  public string tempo;
  public Musica(string cnome, string cartista, string ctempo) {
    nome = cnome;
    artista = cartista;
    tempo = ctempo;
  }
  public void SetNome(string nome) {
    if(nome.Length > 0)this.nome = nome;
  }
  public void SetArtista(string artista) {
    if(artista.Length > 0)this.artista = artista;
  }
  public void SetTempo(string tempo) {
    if(int.Parse(tempo.Substring(0, 2)) > 0 || int.Parse(tempo.Substring(3, 2)) > 0) this.tempo = tempo;
  }
  public string GetNome() {
    return nome;
  }
  public string GetArtista() {
    return artista;
  }
  public string GetTempo() {
    return tempo;
  }
}

public class Playlist {
  Musica[] v = new Musica[19];
  private int aux = 0;
  public void InserirMusica(Musica m) {
    v[aux] = m;
    aux++;
  }
  public override string ToString() {
    return $"{{{v[0].GetNome()}, {v[1].GetNome()}}}";
  }
  public string GetTempoTotal() {
    int min = 0;
    int seg = 0;
    for(int i = 0; i < aux; i++) {
      min += int.Parse((v[i].GetTempo()).Substring(0,2));
      seg += int.Parse((v[i].GetTempo()).Substring(3,2));  
    }
    min += seg / 60;
    seg = seg % 60;
    return $"A playlist dura {min} minutos e {seg} segundos";
  } 
}
