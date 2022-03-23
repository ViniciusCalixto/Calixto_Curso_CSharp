using System;

class Aula19{
    static void Main(){
        
        int[] num=new int[10];

        int contador = 0;

        while (contador < num.Length)
        {   
            num[contador] = 10;

            Console.WriteLine("vetor: " + num[contador]);

            Console.WriteLine("while: " + contador);

            contador++;
        }     
    }
}