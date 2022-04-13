using System;

class Aula25{
    static void Main()
    {
       int numero = 10;
    
        //passagem de argumento por referencia
       DobrarValor(ref numero);
       Console.WriteLine(numero);


    }
    static void DobrarValor(ref int valor)
    {
        valor*=2;
    }
   
}