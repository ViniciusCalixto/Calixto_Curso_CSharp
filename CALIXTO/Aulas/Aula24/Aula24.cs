using System;

class Aula24{
    static void Main()
    {
       //Ex: 1
       for(int i = 0; i < 10;i++)
       {
        NomeMetodoSimples();
       }
        
        //Ex: 2
        NomeMetodoComEntrada(10,5);

        //Ex: 3
        int numero1 = 6;
        int numero2 = 4;
        int Resultado = NomeMetodoComEntradaERetorno(numero1, numero2);
        Console.WriteLine("soma de {0} + {1} = {2}",numero1, numero2, Resultado);

    }
    static void NomeMetodoSimples()
    {
        Console.WriteLine("oXissto");
    }
    static void NomeMetodoComEntrada(int numero1, int numero2)
    {   
        int Resultado = numero1 + numero2;

        Console.WriteLine("soma de {0} + {1} = {2}",numero1, numero2, Resultado);
    }

    static int NomeMetodoComEntradaERetorno(int numero1, int numero2)
    {   
        return numero1 + numero2;
    }
}