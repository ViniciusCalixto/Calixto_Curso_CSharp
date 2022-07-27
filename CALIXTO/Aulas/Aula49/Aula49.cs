using System;

class Matematica{
    public static double PI = 3.14;

    public static int dobro(int n){
        return n * 2;       
    }
}


class Aula49{
    static void Main(){
             
        double valorPI = Matematica.PI;
        int numero = 10;
        
        Console.WriteLine (valorPI);
        Console.WriteLine (Matematica.dobro(numero));
    }   
}