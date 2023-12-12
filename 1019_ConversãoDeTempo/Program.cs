using System;
using System.Globalization;
//globalization por conta do CultureInfo.InvariantCulture

//classe e seu nome
class Program
{

    //metodo sem retorno
    static void Main(string[] args)
    {
        //declaração das variaveis
        int totSegundos, hora, minuto, segundo;

        //leitura do valor que sera inserido no console
        totSegundos = int.Parse(Console.ReadLine()!);

        //dividindo o valor do console por 3600
        //pq 3600? pq Deus quis. Metira, 60 minutos * 60 segundos
        hora = totSegundos / 3600;

        //pegando o resto da divisão de cima, com o %(ou módulo, é usado paraz pegar o resto das divisões.)
        totSegundos = totSegundos % 3600;

        //dividindo o valor do console por 60
        // 60 pa é a quantidade de um segundos num minuto
        minuto = totSegundos / 60;

        //pegando o resto da divisão de cima, com o módulo
        totSegundos = totSegundos % 60;

        //pegando os segundos restantes, eu acho
        segundo = totSegundos;

        //exibindo tudo
        Console.WriteLine($"{hora}:{minuto}:{segundo}");
    }
}
/*ACEITO*/