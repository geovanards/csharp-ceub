using System;
using System.Dynamic;

// Classe abstrata
abstract class Animal {
    protected private string Nome{get; set;} = "";

    // Método abstrato
    public abstract void EmitirSom();

    // Método virtual com implementação
    public virtual void Comer() {
        Console.WriteLine($"Animal: {Nome} está comendo");
    }
}

// Subclasse
class Cachorro : Animal {
    private string _raca;
    public string Raca{
        get {return _raca;}
        set {_raca = value;}
    }

    public Cachorro(string nome, string raca){
        Nome = nome;
        Raca = raca;
    }
    public override void EmitirSom() {
        Console.WriteLine("au au");
    }

    public override void Comer() {
        base.Comer();  // Chama o método da classe base
        Console.WriteLine($"{Nome} está satisfeito");
    }
}

class Program {
    public static void Main(string[] args) {
        Cachorro cachorro_1 = new Cachorro("Totó", "Basset");
        cachorro_1.EmitirSom();
        cachorro_1.Comer();
    }
}
