using System;

class Veiculo{ //classe base
    private int Rodas;
    public int VelocidadeMax;
    public bool Ligado;
    
    public Veiculo(int NumRodas){
        this.Rodas = NumRodas;
    }    
    public void Ligar(){        
        Ligado = true;
    }
    public void Desligar(){        
        Ligado = false;
    }
    public string GetLigado(){
        /*string retorno = "";

        if(Ligado){
            retorno = "Sim";
        }else{
            retorno = "Não";
        }
        return retorno;*/

        return (Ligado ? "Sim" : "Não"); //operador/iF ternario
    }
    public int getRodas(){
        return Rodas;
    }
    public void SetRodas(int NumRodas){
       if (NumRodas < 0 ) {
           this.Rodas = 0;
       }else if (NumRodas > 40 ) {
           this.Rodas = 40;
       } else{
           this.Rodas = NumRodas;
       }     
    }
}

class Carro:Veiculo{
    public string Nome;
    public string Cor;
    public Carro(string Nome, string Cor):base(5){
        Ligar();        
        VelocidadeMax = 120;
        this.Nome = Nome;
        this.Cor = Cor;        
    }
}

class CarroCombate:Carro{
    public int Municao;
    public CarroCombate(string NomeCC, string CorCC):base(NomeCC, CorCC){
        Municao = 100;
        SetRodas(6);
    } 
}
class Aula35{
    static void Main(){
    Carro car1 = new Carro("Relampago Marquinhos", "Vermelho");
    CarroCombate cc1 = new CarroCombate("Tiger", "AZUL");

    Console.WriteLine("Carro COR:...........{0}",car1.Cor);
    Console.WriteLine("Carro Nome:..........{0}",car1.Nome);
    Console.WriteLine("Carro Rodas:.........{0}",car1.getRodas());
    Console.WriteLine("Carro VelocidadeMax:.{0}",car1.VelocidadeMax);
    Console.WriteLine("Carro Ligado:........{0}",car1.GetLigado());
   
    Console.WriteLine("--------------------------------------------");    

    Console.WriteLine("CarroC COR:...........{0}",cc1.Cor);
    Console.WriteLine("CarroC Nome:..........{0}",cc1.Nome);
    Console.WriteLine("CarroC Rodas:.........{0}",cc1.getRodas());
    Console.WriteLine("CarroC VelocidadeMax:.{0}",cc1.VelocidadeMax);
    Console.WriteLine("CarroC Ligado:........{0}",cc1.GetLigado());
    Console.WriteLine("CarroC Munição :........{0}",cc1.Municao);
          
       
    }   
}