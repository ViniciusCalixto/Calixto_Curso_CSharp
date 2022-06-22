using System;
class Galinha{
    private string nomeGalinha;
    private int numeroOvo;

    public Galinha(string nomeGalinha){
        this.nomeGalinha    = nomeGalinha;
        this.numeroOvo      = 0;
    }
    public Ovo Botar(){
        numeroOvo++;
        return new Ovo(numeroOvo, nomeGalinha);
    }
}
class Ovo{
    private int numeroOvo;
    private string MinhaGalinha;
    public Ovo(int numeroOvo, string MinhaGalinha){
        this.numeroOvo      = numeroOvo;
        this.MinhaGalinha   = MinhaGalinha;
        Console.WriteLine("Ovo Criado: {0} - {1}",this.numeroOvo, this.MinhaGalinha);
        
    }
}
class Aula46{
    static void Main(){
        Galinha g1 = new Galinha("Benedita");
        Galinha g2 = new Galinha("Geraldita");
        Galinha g3 = new Galinha("Galinha");
       
       g1.Botar();
       g1.Botar();
       g1.Botar();
       
       g2.Botar();
       g2.Botar();
       g2.Botar();
       g2.Botar();

       g3.Botar();
       g3.Botar();
    }   
}