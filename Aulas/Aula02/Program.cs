using System;

namespace Aula02{
    class Principal{
        static void Main(string[] args){
            
            Console.WriteLine("Olá Mundo...\n");
            Console.WriteLine("CBF Cursos\n");
            
            //validando Argumentos de entrada.
            if(args.GetLength(0) > 0){
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}