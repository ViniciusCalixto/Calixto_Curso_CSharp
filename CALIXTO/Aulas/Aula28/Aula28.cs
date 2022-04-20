using System;

public class Jogador{
    public int Energia = 100;
    public bool Vivo = true;



}
class Aula28{
    static void Main(){
        Jogador j1 = new Jogador();    
        Jogador j2 = new Jogador();    
        Jogador j3 = new Jogador();    

        j1.Energia = 50;

        Console.WriteLine("Energia do J1: {0}",j1.Energia);      
        
        Console.WriteLine("Energia do J2: {0}",j2.Energia);      
              

    }
   

}