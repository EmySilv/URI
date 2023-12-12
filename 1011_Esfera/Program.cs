using System;
//globalization por conta do CultureInfo.InvariantCulture
using System.Globalization;

//classe e seu nome
class Program{
    
    //metodo sem retorno
    static void Main(string[] args){
        // declaração das variaveis
        double raio;
        double pi =  3.14159;
        double total;

        // conversão do valor de raio para double
        raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                                //prioriza o ponto inserido no console
        // fazendo o calculo do exercicio
        total = (4/3.0) * pi * (raio * raio * raio);

        // imprime os valores no console                // delimita a quantidade de casa dps do ponto
        Console.WriteLine("VOLUME = " + total.ToString("F3", CultureInfo.InvariantCulture));
                                                                //prioriza o ponto na hr de imprimir no console
    }
}
