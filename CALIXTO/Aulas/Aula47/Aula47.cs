using System;

class Calc{
    public int soma(params int[]n){
        int soma = 0;
        for(int i = 0; i < n.Length; i++){
            soma +=n[i];
        }           
        return soma;
    }

    public double soma(params double[]n){
        double soma = 0;
        for(int i = 0;i<n.Length;i++){
            soma +=n[i];
        }           
        return soma;
    }
}
class Aula47{
    static void Main(){
        Calc calc = new Calc();
        
        var resultado = calc.soma(10,1.1);
        Console.WriteLine(resultado);
        
    }   
}