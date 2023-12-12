using System;
using System.Globalization;
//globalization por conta do CultureInfo.InvariantCulture

//classe e seu nome
class Program{

    //metodo sem retorno
    static void Main(string[] args){
        // declaração das variaveis 
        double x1, y1, x2, y2, distancia;

        
        string[] linha1 = Console.ReadLine()!.Split(' ');  
        x1 = double.Parse(linha1[0], CultureInfo.InvariantCulture);
        y1 = double.Parse(linha1[1], CultureInfo.InvariantCulture);
        
        string[] linha2 = Console.ReadLine()!.Split(' ');
        x2 = double.Parse(linha2[0], CultureInfo.InvariantCulture);
        y2 = double.Parse(linha2[1], CultureInfo.InvariantCulture);

        distancia = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
        
        Console.WriteLine(distancia.ToString("F4"), CultureInfo.InvariantCulture);
    }
}