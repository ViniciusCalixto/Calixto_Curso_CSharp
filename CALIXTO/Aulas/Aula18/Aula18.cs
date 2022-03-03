using System;

class Aula18{
    static void Main(){
       //int n1, n2, n3, n4, n5;
       int[] nArray = new int[5];

       nArray[0] = 10;
       nArray[1] = 11;
       nArray[2] = 12;
       nArray[3] = 13;
       nArray[4] = 14;

       Console.WriteLine("array posição 0: {0}",nArray[0]);


        int[] nArray_B = new int[3]{10, 11, 12};
       

        Console.WriteLine("array posição 0: {0}",nArray[0]);


        int[] nArray_C = {10, 11, 12};

        Console.WriteLine("array posição 0: {0}",nArray[0]);


        int[,] nArray_Matriz = new int[2,3];
        
        nArray_Matriz[0,0] = 0;
        nArray_Matriz[0,1] = 1;
        nArray_Matriz[0,2] = 2;

        nArray_Matriz[1,0] = 4;
        nArray_Matriz[1,1] = 5;
        nArray_Matriz[1,2] = 6;

              
        Console.WriteLine("array posição [0,2]: {0}",nArray_Matriz[0,1]);


        int[,] nArray_Matriz_A = new int[2,2]{{10,20},{30,40}};
        
                      
        Console.WriteLine("array posição [0,1]: {0}",nArray_Matriz_A[0,1]);


    }
}