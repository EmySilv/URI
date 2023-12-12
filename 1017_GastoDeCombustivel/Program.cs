using System;
using System.Globalization;
//globalization por conta do CultureInfo.InvariantCulture

//classe e seu nome
class Program{

    //metodo sem retorno
    static void Main(string[] args){
    float temp, velocidade, resultado;
    int gastoCarro = 12;

    temp = float.Parse(Console.ReadLine()!);
    velocidade = float.Parse(Console.ReadLine()!);

    resultado = (temp * velocidade) / gastoCarro;   
    Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
    }
}
