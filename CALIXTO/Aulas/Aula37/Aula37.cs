using System;
class Base{
    public Base(){
        Console.WriteLine("Constrututor da classe base");
    }
}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Constrututor da classe Derivada1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Constrututor da classe Derivada2");
    }
}
class Aula36{
    static void Main(){
        Derivada2 teste = new Derivada2();
                
       
    }   
}