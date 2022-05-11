using System;

public class Jogador{
    public int Energia;
    public bool Vivo;
    public string Nome;

    //construtor tem o mesmo nome da classe
    public Jogador(){
        Energia = 100;
        Vivo    = true;
        Nome    = "Jogador";
    }

    public Jogador(string paramNome){
        Energia = 100;
        Vivo    = true;
        Nome    = paramNome;
    }
    public Jogador(string paramNome,int paramEnergia){
        Energia = paramEnergia;
        Vivo    = true;
        Nome    = paramNome;
    }
    public Jogador(string paramNome, int paramEnergia, bool paramVivo){
        Energia = paramEnergia;
        Vivo    = paramVivo;
        Nome    = paramNome;
    }
    public void Informacoes(){
        Console.WriteLine("=========================");
        Console.WriteLine("Nome do Jogador....: {0};", Nome);
        Console.WriteLine("Energia do Jogador.: {0};", Energia);
        Console.WriteLine("Estadodo Jogador...: {0};", Vivo);
        Console.WriteLine("=========================");
    }
   
}
class Aula30{
    static void Main(){
        Jogador j1 = new Jogador();    
        Jogador j2 = new Jogador("oToXisto");    
        Jogador j3 = new Jogador("Calixto", 100);    
        Jogador j4 = new Jogador("Zigo", 50,true);    
        Jogador j5 = new Jogador("Morto", 0,false); 

        j1.Informacoes();
        j2.Informacoes();
        j3.Informacoes();
        j4.Informacoes();
        j5.Informacoes();
    }   
}