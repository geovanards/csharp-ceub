using System;
class Pessoa(){
    //atributos 

    public string nome = "";
    public int idade = 0;

//Método de exibir informações:
    public void Apresentar(){
        Console.WriteLine($"Olá, meu nome é {nome} e eu tenho {idade} anos.");
    }
}


// essa pessoa existe e tem atributos(2) e metodo apresentar:
class Program{
    static void Main(string[] args){
        Pessoa pessoa_1 = new Pessoa();
        pessoa_1.nome = "Ana";
        pessoa_1.idade = 16;
        pessoa_1.Apresentar();
    }
}
