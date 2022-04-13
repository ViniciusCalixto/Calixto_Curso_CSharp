using System;

class Aula23{
    static void Main(){

        int [] vetor1 = new int[5];
        int [,] matriz= new int[3,5]{
            {11,22,00,44,20},
            {66,77,88,99,00},
            {66,77,88,99,00}};
        
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);    
        Console.WriteLine("Maior: {0}", MaiorIndiceVetor);
        
        int MaiorIndiceMatriz = matriz.GetUpperBound(1);    
        Console.WriteLine("Maior: {0}", MaiorIndiceMatriz   );

        Console.WriteLine("getlong");
        int qtdelementos = Convert.ToInt32(matriz.GetLongLength(1));    
        Console.WriteLine("qtd: {0}", qtdelementos);
        
    }
}