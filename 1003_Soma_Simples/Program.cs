//importação
using System;

//classe e seu nome
class Program{
    //metodo sem retorno
    static void Main(string []args)
    {
    //ENTRADA
        //declaração de variáveis
        int val1, val2, soma;

        //leitra e conversão de variaveis
        val1 = int.Parse(Console.ReadLine());
        val2 = int.Parse(Console.ReadLine());
    
    //PROCESSAMENTO
        soma = val1 + val2;

    //SAIDA
        Console.WriteLine("SOMA = " + soma);
    }
}
/*ACEITO*/
