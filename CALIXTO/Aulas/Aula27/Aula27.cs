using System;

class Aula27{
    static void Main()
    {
      
        Somar();
        Somar(1);
        Somar(1,1);
        Somar(1,1,1,1);
        

    }
   
   static void Somar(params int[]n)
   {
       int resultado = 0;

       if (n.Length < 1) {
            Console.WriteLine("nao existe valores");
       }else if(n.Length < 2){
            Console.WriteLine("valores insuficientes para soma");
       }else{
           for (int i = 0; i < n.Length; i++)
           {
               resultado += n[i];
           }
            Console.WriteLine("Soma dos valores = {0}",resultado);
       }      
       
   }

}