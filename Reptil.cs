public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) { }

    public override string EmitirSom()
    {
        throw new NotImplementedException();
    }
}

public class Cobra : Reptil 
{
    public Cobra(string nome, int idade) : base(nome, idade){}

    public double Comprimento { get; set; }

    public override string EmitirSom() 
    {
        return "A Cobra sibila!";
    }
}
