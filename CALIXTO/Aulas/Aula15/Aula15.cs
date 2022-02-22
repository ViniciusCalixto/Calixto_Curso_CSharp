using System;

class Aula15{
    static void Main(){
       
       int tempo = 0;
       char escolha;

        Console.WriteLine("Belo Horizonte/BH a Vitória/ES");
        Console.WriteLine("Escolha o transporte:[A]=Avião | [C]=Carro | [O]=Onibus");
        
        escolha = char.Parse(Console.ReadLine());
       
        switch (char.ToUpper(escolha)){
            case 'A':
                tempo = 50;
                break;
            case 'C':           
                tempo = 480;
                break;
            case 'O':
                tempo = 660;
                break;
            default:
                tempo =-1;
                break;
        }
        if(tempo < 0){
            Console.WriteLine("Transporte indisponivel");
        }else{
            Console.WriteLine("O tempo para o Transporte escolhido é: {0} minutos", tempo);
        }
        
     
    }
}