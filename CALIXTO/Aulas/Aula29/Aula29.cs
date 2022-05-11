using System;

public class Jogador{
    public int Energia;
    public bool Vivo;
    public string Nome;
    public Jogador(string paramNome){
        Energia = 100;
        Vivo    = true;
        Nome    = paramNome;
    }

    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruido;",Nome);
    }

}
class Aula28{
    static void Main(){
        Jogador j1 = new Jogador("oXisto");    
        Jogador j2 = new Jogador("oToXisto");    
        Jogador j3 = new Jogador("");    

        j1.Energia = 50;

        Console.WriteLine("Energia do J1: {0}",j1.Energia);
        Console.WriteLine("Energia do J2: {0}",j2.Energia);      
        
        Console.WriteLine("Nome do J1: {0}",j1.Nome); 
        Console.WriteLine("Nome do J2: {0}",j2.Nome); 

        
        Console.Write("Nome do P3:");
        j3.Nome = Console.ReadLine();
        Console.WriteLine("Nome do J3 digitado: {0}",j3.Nome);            
    }   
}