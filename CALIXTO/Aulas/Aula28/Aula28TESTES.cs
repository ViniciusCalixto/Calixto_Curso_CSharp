using System;

public class Calculos{
    public int Valor1 = 0;
    public int Valor2 = 0;
   
    public int Somar()
    {         
        AtributirValores();         
        return Valor1 + Valor2;
    }

    private void AtributirValores()
    {                  
        Valor1 = 10;
        Valor2 = 10;
    }

}
class Aula28Testes{
    static void Main(){
        Calculos calc = new Calculos();    
        
        calc.Valor1 =  5;
        calc.Valor2 = 10;

        Console.WriteLine("AntesValor 1: {0}",calc.Valor1);      
        Console.WriteLine("AntesValor 2: {0}",calc.Valor2);

        Console.WriteLine("Soma   : {0}",calc.Somar()); 

        Console.WriteLine("DepoisValor 1: {0}",calc.Valor1);      
        Console.WriteLine("DepoisValor 2: {0}",calc.Valor2);          
               
    }
}
