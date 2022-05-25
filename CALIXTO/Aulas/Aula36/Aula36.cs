using System;

class Veiculo{ //base
    public int VeloAtual;
    private int VeloMax;
    protected bool Ligado;
    public string statusLigado;

    public Veiculo(int paramVeloMax){
        VeloAtual = 0;
        this.VeloMax = paramVeloMax;
        Ligado = false; 
        statusLigado = "Não";
    }
    public bool GetLigado(){
        return Ligado;
    }
    public int GetVeloMax(){
        return VeloMax;
    }
}
class Carro:Veiculo{//derivada
    public string NomeCarro;

    public Carro(string ParamNomeCarro, int ParamVeloMax):base(ParamVeloMax){
        this.NomeCarro = ParamNomeCarro;
        Ligado = true;       
    }
}
class Aula36{
    static void Main(){
        Carro car1 = new Carro("Relampago Marquinhos", 100);
        
        Console.WriteLine("Nome:....{0}",car1.NomeCarro);
        Console.WriteLine("VeloMax:.{0}",car1.GetVeloMax());
        Console.WriteLine("Ligado:..{0}",car1.GetLigado());
        Console.WriteLine("statusLigado:..{0}",car1.statusLigado);
       
    }   
}