using System;
class Carro(){
    //atributos 

    public string marca = "";
    public string modelo = "";

    public int anoDeFabricacao = 0;



// Método de ligar o carro
public void Ligar(){
        Console.WriteLine($"{marca} {modelo} está ligado!");
    }

    public void SetModelo(string novoModelo){
        if (novoModelo != ""){
            modelo = novoModelo;
        }
    }

    public void setMarca(string novaMarca){
        if (novaMarca != ""){
            marca = novaMarca;
        }
    }
}


class Program {
        static void Main(string[] args){
        Carro carro_1 = new Carro();
        carro_1.marca = "Toyota";
        carro_1.modelo = "Corolla";
        carro_1.anoDeFabricacao = 2016;
        carro_1.Ligar();
        
    }
 } 
 
