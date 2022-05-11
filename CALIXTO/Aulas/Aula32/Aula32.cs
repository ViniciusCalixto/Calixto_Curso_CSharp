using System;

class Calculos{
     public int Valor1;
     public int Valor2;

    public Calculos(int Valor1, int Valor2){
        this.Valor1 = Valor1;
        this.Valor2 = Valor2;

    }
    //construtor tem o mesmo nome da classe
    public int Somar(){

        return Valor1 + Valor2;
    }  
   
}
class Aula32{
    static void Main(){
          
       Calculos calc = new Calculos(10,2);

       Console.WriteLine(calc.Somar());
    }   
}