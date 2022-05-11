using System;

static class Jogador{
    static public int Energia;
    static public bool Vivo;
    static public string Nome;

    //construtor tem o mesmo nome da classe
    static public void Iniciar(){
        Energia = 100;
        Vivo    = true;
        Nome    = "Jogador";
    }


    static public void Informacoes(){
        Console.WriteLine("=========================");
        Console.WriteLine("Nome do Jogador....: {0};", Nome);
        Console.WriteLine("Energia do Jogador.: {0};", Energia);
        Console.WriteLine("Estadodo Jogador...: {0};", Vivo);
        Console.WriteLine("=========================");
    }
   
}
class Inimigo{
    static public bool Alerta;
    public string Nome;

    public Inimigo(string n){
        Alerta = false;
        Nome = n;        
    }
    public void InfoInimigo(){
        Console.WriteLine(Nome);
        Console.WriteLine(Alerta);
        Console.WriteLine("------------------");
    }
}
class Aula31{
    static void Main(){
          
        Jogador.Iniciar();
        Jogador.Informacoes();


        Inimigo i1 = new Inimigo("Boss1");
        Inimigo i2 = new Inimigo("Boss2");
        Inimigo i3 = new Inimigo("Boss3");

        Inimigo.Alerta = true;

        i1.InfoInimigo();
        i2.InfoInimigo();
        i3.InfoInimigo();
    }   
}