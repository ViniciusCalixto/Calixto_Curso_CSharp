using System;

class Aula14{
    static void Main(){
       
        int nota1, nota2, nota3, nota4, media;
        nota1 = nota2 = nota3 = nota4 = media = 0;
        string resultado3 ;

        Console.WriteLine("Digita a nota 1:");
        nota1 = int.Parse(Console.ReadLine());
       
        Console.WriteLine("Digita a nota 2:");
        nota2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digita a nota 3:");
        nota3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digita a nota 4:");
        nota4 = int.Parse(Console.ReadLine());
        
        media = nota1 + nota2 + nota3 + nota4;
        // aprovado     >= 60
        //recuperacao   59 e 40
        // reprovado    < 40
/*
        if(media < 40){
            resultado3 = "Reprovado";
        }else if(media < 60){
           resultado3 = "Recuperação";
        }else{
            resultado3 = "Aprovado";
        }*/

        //if alinhado
        if(media > 60){
            if(media >= 90){
                if(media >= 99){
                    resultado3 = "Aprovado com super louvor";
                }else{
                    resultado3 = "Aprovado com louvor";
                }
            }else{
                resultado3 = "Aprovado";
            }
        }else {
            if(media >= 40){
                resultado3 = "Recuperação";
            }else{
                resultado3 = "Reprovado";
            }
        }
        
        Console.WriteLine("Media: {0} \nResultado: {1}", media, resultado3);
     
    }
}