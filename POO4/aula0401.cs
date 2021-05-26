using System;

class MainClass {
  public static void Main (string[] args){
    // double é um tipo por valor e bx armazena o inteiro na stack
    double bx = 10;
    double hx = 10;
    // string é um tipo por referência e cx não armazena "azul" na stack e sim o endereço de memória doq ta na heap e n precisa de new pq é especial
    string cx ="azul";
    // tipo por  referencia
    //isso faz com q b, h e c recebam o que está no main
    Triangulo x = new Triangulo(bx, hx, cx);
  }
}

class Triangulo {
  private double b,h;
  private string c;

  public Triangulo(double b, double h, string c){
    // não valida, so armazena
    // this é oq ta la em cima e diz q o valor q está no parametro x vai para o atributo x na memoria heap
    this.b = b;
    this.h = h;
    this.c = c;
  }


}