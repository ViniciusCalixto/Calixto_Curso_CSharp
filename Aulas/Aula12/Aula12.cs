using System;

class Aula12{
    static void Main(){
        
       //SE(E_L){}
       //EXPRESSAO LOGICA(> < >= <= == !=)

        int nota = 80 ;
        string resultado = "Reprovado";

        if(nota >= 60){
            resultado = "Aprovado";
        }        
        Console.WriteLine("Resultado: {0}", resultado);


        int notaAluno = 0 ;
        string resultado2 = "Reprovado";
        
        notaAluno = int.Parse(Console.ReadLine());

        if(notaAluno >= 60){
            resultado2 = "Aprovado";
        }        
        Console.WriteLine("Resultado: {0}", resultado2);
        
        int nota1, nota2, nota3, nota4, media;
        nota1 = nota2 = nota3 = nota4 = media = 0;
        string resultado3 = "Reprovado";

        Console.WriteLine("Digita a nota 1:");
        nota1 = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Digita a nota 2:");
        nota2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digita a nota 3:");
        nota3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digita a nota 4:");
        nota4 = int.Parse(Console.ReadLine());
        
        media = nota1 + nota2 + nota3 + nota4;

        if(media >= 60){
            resultado3 = "Aprovado";
        }        
        Console.WriteLine("Media: {0} \nResultado: {1}", media, resultado3);


        
        string nome = "vinicius está programando C#";
        Console.WriteLine(nome);


    }
}