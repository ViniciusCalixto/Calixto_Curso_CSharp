using System;

class Aula17{
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
    }
}