using System;

class Aula19{
    static void Main(){

        int numero = 5;

        do{
            Console.WriteLine("oXissto");
        } while (numero < 5);


        Console.WriteLine("Sistema de senha.");  

        string senha="123";
        string senhaUsuario;
        int tentativas = 0;
        bool Liberado = false;
        /*
        do{                        
            Console.Clear();
            if(tentativas > 0){ //1
                Console.Write("senha incorreta, digite novamente!");                
            }
            Console.Write("Digite a senha:");
            senhaUsuario = Console.ReadLine();   
            
            tentativas++; //1        
        } while (senha != senhaUsuario);
        */
/*
         do{                        
           Console.Clear();           
            Console.Write("Digite a senha:");
            senhaUsuario = Console.ReadLine();   
            
            if(senha == senhaUsuario){ 
                Liberado = "Acertou";
            }else{
                Console.WriteLine("senha incorreta, digite novamente!");
            }
            if (tentativas == 2){
                Liberado = "Errou";
            }            
            tentativas++;               
        }  while (Liberado == "");
*/
        do{                        
           Console.Clear();           
            Console.Write("Digite a senha:");
            senhaUsuario = Console.ReadLine();   
            
            if(senha == senhaUsuario){ 
                Liberado = true;
            }else{
                Console.WriteLine("senha incorreta, digite novamente!");               
            }                          
            tentativas++;               
        }  while (Liberado == false && tentativas != 3); 
        //false 0 = verdade
        //false 1 = verdade
        //false 5 = mentida

        Console.Clear();
        if (Liberado ){
            Console.WriteLine("Liberado!, tentativas:{0}", tentativas);
        }else{
            Console.WriteLine("Bloqueado!, tentativas:{0}", tentativas);
        }
        
            
        
    }
}