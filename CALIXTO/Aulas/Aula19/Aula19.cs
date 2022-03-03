using System;

class Aula19{
    static void Main(){
        
        int length = 10;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("oXissto " + i);
        }


        int[] vetor = new int[10];

        for (int i = 0; i < length; i++)
        {   
            vetor[i] = 0;
            
        }

        for (int i = 0; i < vetor.Length; i++)
        {   
            vetor[i] = 0;
            
        }

        Console.WriteLine("oXissto");

    }
}