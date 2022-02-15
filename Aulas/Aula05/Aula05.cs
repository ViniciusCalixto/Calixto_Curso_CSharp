using System;

class Aula05{
    static void Main(){
        
        int resultado = 10 + 5;
        Console.WriteLine(resultado);

        int resultado2 = (10 + 5) * 2;
        Console.WriteLine(resultado2);
        
        bool resultado3 = 10 < 5;
        Console.WriteLine(resultado3);
        
        bool resultado4 = 10 > 5;
        Console.WriteLine(resultado4);

        // operadores < > >= <= != 


        int resultado5 = 10;
        resultado5 += 1;
        Console.WriteLine(resultado5);


        int resultado6 = 10;
        resultado6 ++;
        Console.WriteLine(resultado6);

        //& = AND  = E
        //| = OR   = OU
        bool resultado7 = (5 > 3) | (10 < 5);
        Console.WriteLine("resultado 7: " + resultado7);

        bool resultado8 = (5 > 7) | (10 < 5);
        Console.WriteLine(resultado8);

         bool resultado9 = (5 > 3) & (10 > 5);
        Console.WriteLine(resultado9);
        

    }
}