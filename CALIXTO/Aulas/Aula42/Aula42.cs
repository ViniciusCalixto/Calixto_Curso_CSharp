using System;
class Carro{
    private int[] VeloMax = new int[5]{80,120,160,240,300};

    public int this[int i]{
        get{
            return VeloMax[i];
        }
        set{
            if(value < 0){
                this.VeloMax[i] = 0;
            }else if(value > 300){
                this.VeloMax[i] = 300;
            }else{
                this.VeloMax[i] = value;
            }            
        }
    }

    public Carro(){       
    }
}
class Aula42{
    static void Main(){
       
       Carro car1 = new Carro();
       
       car1[4] = 100; 
       Console.WriteLine("velocidade: {0}", car1[4]);      
       Console.WriteLine("velocidade: {0}", car1[1]);
    }   
}