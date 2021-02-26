using System;

class MainClass {
  public static void Main (string[] args) {
    Disciplina d = new Disciplina();
    Console.WriteLine("Escreva o nome da disciplina.");
    d.SetNome((Console.ReadLine()));
    Console.WriteLine("Escreva as notas dos bimestres. Uma em cada linha.");
    d.SetNota1(int.Parse(Console.ReadLine()));
    d.SetNota2(int.Parse(Console.ReadLine()));
    d.SetNota3(int.Parse(Console.ReadLine()));
    d.SetNota4(int.Parse(Console.ReadLine()));

    int mediaparcial = d.CalcMediaParcial();
    int mediafinal = d.CalcMediaFinal();

    if (d.CalcMediaParcial() >= 60){
      Console.WriteLine($"Você foi aprovado em {d.GetNome()} com a média {mediaparcial}.");
    }
    if (d.CalcMediaParcial() < 60){
      Console.WriteLine($"Você foi reprovado em {d.GetNome()} com a média {mediaparcial}. Escreva a nota da prova final.");
    }
    d.SetNotaFinal(int.Parse(Console.ReadLine()));
    if (d.CalcMediaFinal() < 60){
      Console.WriteLine($"Você foi reprovado em {d.GetNome()} com a média final {mediafinal}.");
    }
    if (d.CalcMediaFinal() >= 60){
      Console.WriteLine($"Você foi aprovado em {d.GetNome()} com a média final {mediafinal}.");
    }
  }
}

class Disciplina {
  private string nome;
  private int nota1, nota2, nota3, nota4, notaFinal, media;
  public void SetNome(string s){
    if(s.Length > 0) nome = s;
  }
  public void SetNota1(int n){
    if(n > 0) nota1 = n;
  }
  public void SetNota2(int n){
    if(n > 0) nota2 = n;
  }
  public void SetNota3(int n){
    if(n > 0) nota3 = n;
  }
  public void SetNota4(int n){
    if(n > 0) nota4 = n;
  }
  public void SetNotaFinal(int n){
    if(n > 0) notaFinal = n;
  }
  public string GetNome(){
    return nome;
  }
  public int GetNota1(){
    return nota1;
  }
  public int GetNota2(){
    return nota2;
  }
  public int GetNota3(){
    return nota3;
  }
  public int GetNota4(){
    return nota4;
  }
  public int GetNotaFinal(){
    return notaFinal;
  }
  public int CalcMediaParcial() {
    media = ((nota1 * 2) + (nota2 * 2) + (nota3 * 3) + (nota4 * 3)) / 10;
    return media;
  }
  public int CalcMediaFinal() {
    media = ((nota1 * 2) + (nota2 * 2) + (nota3 * 3) + (nota4 * 3)) / 10;
    media = (media + notaFinal) / 2;
    return media;
  }
}