using System;

class Aula03{
    static void Main(){
        //32 bits de dados 
        int num = 0;
        int num2 = -10;
        
        byte n1 = 10; //0 e 255

        char letra = 'c'; //char usa apenas 1 caracter e tem que ser apostofro
        float valorReal = 5.3f;
        
        string nomes = "string usa aspas";
        
        //o tipo do var é de acordo com a primeira inicialização dela
        var aux = 10; //int
        var aux2 = "var do tipo string"; //string

        //declarar multiplas var do mesmo tipo
        int numero1, numero2, numero3;
        numero1 = 10;
        numero2 = 2;
        numero3 = numero1 * numero2;

        Console.WriteLine("Valor da variavel aux: " + aux + "...");
        Console.WriteLine("\n");
        Console.WriteLine("Valor de " + numero1 + " vezes " + numero2 + " é igual a: " + numero3 );


    }
}