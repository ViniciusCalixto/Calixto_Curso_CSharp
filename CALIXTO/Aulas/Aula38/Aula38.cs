using System;
class Base{
    public string nome;
    public Base(){
        this.nome = "Base";
        Console.WriteLine("Constrututor da classe base");
    }
    virtual public void Info(){
        Console.WriteLine("InfoBase");
    }
}
class Derivada1:Base{
    public Derivada1(){
        this.nome = "Derivada1";
        Console.WriteLine("Constrututor da classe Derivada1");
    }
    override public void Info(){
        Console.WriteLine("InfoDerivada 1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        this.nome = "Derivada2";
        Console.WriteLine("Constrututor da classe Derivada2");
    }
    override public void Info(){
        Console.WriteLine("InfoDerivada 2");
    }
}
class Aula36{
    static void Main(){
       /*
        Base referencia;
        Derivada1 D1 = new Derivada1();
        Derivada2 D2 = new Derivada2();
        
        referencia=D1;
        referencia.Info();

        referencia=D2;
        referencia.Info();  

*//*
        Base B = new Base(); 
        Derivada1 D1 = new Derivada1(); //player 1
        Derivada2 D2 = new Derivada2(); //player 1
        
        Console.WriteLine("Nome: {0}", B.nome);
        Console.WriteLine("Nome: {0}", D1.nome);        
        Console.WriteLine("Nome: {0}", D2.nome);
        Console.WriteLine("-------------------");
        B.nome = "BASE ALTERADA";

        Console.WriteLine("Nome: {0}", B.nome);
        Console.WriteLine("Nome: {0}", D1.nome);        
        Console.WriteLine("Nome: {0}", D2.nome);
*/

        Base Ref; 
        Derivada1 D1 = new Derivada1(); //player 1
        Derivada2 D2 = new Derivada2(); //player 1        
        Derivada2 D3 = new Derivada2();

        Ref = D1;
        Console.WriteLine("Nome 1: {0}", Ref.nome);
        Ref = D2;
        Console.WriteLine("Nome 2: {0}", Ref.nome);
       
        Ref = D1;
        Ref.nome = "Ref ALTERADA 1x";
        
        Ref = D2;      
        //Ref.nome = "Ref ALTERADA 2x";

        Console.WriteLine("-------------------");        

        Console.WriteLine("Nome : {0}", Ref.nome);

        Console.WriteLine("-------------------");
        Console.WriteLine("Nome D1: {0}", D1.nome);
        Console.WriteLine("Nome D2: {0}", D2.nome);
        Console.WriteLine("Nome D3: {0}", D3.nome);
       
    }   
}