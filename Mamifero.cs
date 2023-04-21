public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }

    public override string EmitirSom()
    {
        throw new NotImplementedException();
    }
}

public class Leao : Mamifero 
{
    public Leao(string nome, int idade) : base(nome, idade) { }
    public int TamanhoDoGrupo { get; set; }

    public override string EmitirSom() 
    {
        return "O Leão ruge!";
    }
}

