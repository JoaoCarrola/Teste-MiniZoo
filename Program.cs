class Program
{
    static void Main(string[] args)
    {
        MiniZoo miniZoo = new MiniZoo();
        miniZoo.AdicionarAnimal(new Leao("Leão", 3));
        miniZoo.AdicionarAnimal(new Mamifero("Mamífero", 5));
        miniZoo.EmitirSomDeTodosOsAnimais();
        miniZoo.ImprimirTodosOsAnimais();
    }
}
