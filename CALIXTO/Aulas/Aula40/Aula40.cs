using System;
sealed class Veiculo{
    //nao pode ser uma sealed e abstract 
}

class Carro:Veiculo{

}
class Aula40{
    static void Main(){
       Carro car1 = new Carro();
    }   
}