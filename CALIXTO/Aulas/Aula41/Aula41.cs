using System;
class Carro{
    private int VeloMax;
    public int velocidadeMaxima{//acessors
        get{
            return VeloMax;
        }
        set{
            if(value < 0){
                this.VeloMax = 0;
            }else if(value > 300){
                this.VeloMax = 300;
            }else{
                this.VeloMax = value;
            }            
        }
    }
    public Carro(){
        this.velocidadeMaxima = 120;
    }
}
class Aula41{
    static void Main(){
       Carro car1 = new Carro();
       Console.WriteLine("velocidade: {0}", car1.velocidadeMaxima);
       car1.velocidadeMaxima = 100; 
       Console.WriteLine("velocidade: {0}", car1.velocidadeMaxima);
    }   
}