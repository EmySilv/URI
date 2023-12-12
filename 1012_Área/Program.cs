using System;
//globalization por conta do CultureInfo.InvariantCulture
using System.Globalization;

//classe e seu nome
class Program{
    
    //metodo sem retorno
    static void Main(string[] args){
        //declaração e leitura das variáveis
        double pi = 3.14159;
        double valorA, valorB, valorC, triangulo, circulo, trapezio, quadrado, retangulo;

        //criando uma lista do tipo string com nome de 'linha1' e fazendo a leitura dessa linha
        string[] linha1 = Console.ReadLine().Split(' ');
                                            // .Split (' ')  divide uma string em vários pedaços, 
                                            // transformando em um array, ele basuicamente descarta esse espaço que digitamos

        // convertendo os valores para double e informando as posiçõess deles na lista
        valorA = double.Parse(linha1[0], CultureInfo.InvariantCulture);
        valorB = double.Parse(linha1[1], CultureInfo.InvariantCulture);
        valorC = double.Parse(linha1[2], CultureInfo.InvariantCulture);
        
        // making os calculos
        triangulo = (valorA * valorC) / 2;
        circulo = pi * (valorC * valorC);
        trapezio = ((valorA + valorB) * valorC) / 2;
        quadrado = (valorB * valorB);
        retangulo = (valorA * valorB);

        // exibindo os valores no console
        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }
}
