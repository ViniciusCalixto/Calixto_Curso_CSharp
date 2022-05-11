using System;

class Jogador{
     private int Energia;
     private string Nome;

     
    public Jogador(string Nome){
        this.Nome = Nome;
        Energia = 100;

    }
    public int getEnegia(){
        return Energia;
    }
    public string getNome(){
        return Nome;
    }
    public void setEnegia(int ValorEnegia){
        if(ValorEnegia < 0 ){
            if(Energia + ValorEnegia < 0){
                Energia = 0;
            }else{
                Energia += ValorEnegia;
            }
        }else if(ValorEnegia > 0){
            if(Energia + ValorEnegia > 100){
                Energia = 100;
            }else{
                Energia += ValorEnegia;
            }
        }        
    }   
    public void setNome(string n){
        Nome = n;
    }
}
class Aula33{
    static void Main(){
          
       Jogador j1 = new Jogador("Calixto");
        
        j1.setEnegia(-30);
        j1.setEnegia(-30);
        j1.setEnegia(-30);
        j1.setEnegia(-30);
        j1.setEnegia(50);

       Console.WriteLine("Nome: {0}",j1.getNome());
       Console.WriteLine("Energia: {0}",j1.getEnegia());
    }   
}