using System;
abstract class Veiculo{//base abstrata
    protected int VeloMax;
    protected int VeloAtual;
    protected bool CarLigado;

    public Veiculo(){
        CarLigado = false;
        VeloAtual = 0;        
    }
    public void setLigado(bool ligado){
        this.CarLigado = ligado;
    }
    public int getVeloAtual(){
        return this.VeloAtual;
    }
    abstract public void Aceleracao(int Mult);

}
class Carro:Veiculo{
    public Carro(){
        this.VeloMax = 120;
    }
    override public void Aceleracao(int Mult){
        this.VeloAtual += 10 * Mult;
    }

}
class Aula39{
    static void Main(){
        Carro car1 = new Carro();  
        car1.Aceleracao(1);
        car1.Aceleracao(1);
        Console.WriteLine(car1.getVeloAtual());
        car1.Aceleracao(-1);
        Console.WriteLine(car1.getVeloAtual());
    }   
}