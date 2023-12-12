using System;
//globalization por conta do CultureInfo.InvariantCulture
using System.Globalization;

//classe e seu nome
class Program
{

    //metodo sem retorno
    static void Main(string[] args)
    {       
        // declaração das variaveis
        int distancia;
        double combustivel, total;

        // leitura de valores
        distancia = int.Parse(Console.ReadLine()!);
        combustivel = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        // making the conta
        total = distancia / combustivel;

        // imprimindo no console        // delimitando a quantidade de casas
        Console.WriteLine(total.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
    }
}