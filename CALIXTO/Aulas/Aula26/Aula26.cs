using System;

class Aula26{
    static void Main()
    {
      
        int numero1, numero2, quociente, Resto;

        numero1 = 10;
        numero2 =  3;
        quociente = divisao(numero1, numero2, out Resto);

        Console.WriteLine("{0}/{1} : q ={2} e resto={3}", +
         numero1, numero2, quociente, Resto);

    }
   
   static int divisao(int dividendo,int divisor, out int resto)
   {
       resto = dividendo % divisor;

       int quociente = dividendo / divisor;

       return quociente;
   }

}