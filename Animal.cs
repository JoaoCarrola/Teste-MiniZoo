public abstract class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public abstract string EmitirSom();
    
    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

}
