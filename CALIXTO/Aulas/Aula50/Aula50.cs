using System;

delegate int Operacao(int n1, int n2);
class Matematica{
    public static int Soma(int n1, int n2){
        return n1 + n2;
    }

    public static int Mult(int n1, int n2){
        return n1 * n2;
    }
    
}


class Aula49{
    static void Main(){
        int resultado;

        Operacao delega1 = new Operacao(Matematica.Soma);
        resultado = delega1(10,5);

        Console.WriteLine (resultado);

        delega1 = new Operacao(Matematica.Mult);

        resultado = delega1(2,2);

        Console.WriteLine (resultado);

    }   
}