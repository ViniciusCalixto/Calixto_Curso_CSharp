using System;

class Veiculo{ //classe base
    public int Rodas;
    public int VelocidadeMax;
    public bool Ligado;
    
    public void Ligar(){        
        Ligado = true;
    }
    public void Desligar(){        
        Ligado = false;
    }
    public string GetLigado(){
        string retorno = "";

        if(Ligado){
            retorno = "Sim";
        }else{
            retorno = "Não";
        }
        return retorno;
    }
}

class Carro:Veiculo {
    public string Nome;
    public string Cor;
    public Carro(
        string Nome, string Cor)
    {
        Desligar();
        Rodas = 4;
        VelocidadeMax = 120;
        this.Nome = Nome;
        this.Cor = Cor;        
    }
}
class Aula34{
    static void Main(){
    Carro car1 = new Carro("Relampago Marquinhos", "Vermelho");
    
    Console.WriteLine("Carro COR:...........{0}",car1.Cor);
    Console.WriteLine("Carro Nome:..........{0}",car1.Nome);
    Console.WriteLine("Carro Rodas:.........{0}",car1.Rodas);
    Console.WriteLine("Carro VelocidadeMax:.{0}",car1.VelocidadeMax);
    Console.WriteLine("Carro Ligado:........{0}",car1.GetLigado());
       
    }   
}