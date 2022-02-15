using System;

class Aula08{
    static void Main(){
        
        int v1, v2, soma;
        string nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Nome digitado: {0}", nome);
        
        Console.Write("\nDigite valor 1: ");
        v1 = int.Parse(Console.ReadLine());

        Console.Write("\nDigite valor 2: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        
        soma = v1 + v2;

        Console.WriteLine("Soma: {0}", soma);



    }
}