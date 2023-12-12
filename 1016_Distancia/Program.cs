using System;
using System.Globalization;
//globalization por conta do CultureInfo.InvariantCulture

//classe e seu nome
class Program{

    //metodo sem retorno
    static void Main(string[] args){
        int distancia, calculo;
    
        distancia = int.Parse(Console.ReadLine()!);
        calculo = distancia * 2;

        // Interpolação: Utilizar o $ e as {variavel} para juntar uma String junto com uma
        // variável, sem precisar concatenar.
        Console.WriteLine($"{calculo} minutos");
    }
}
