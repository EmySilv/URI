using System;
class Program
{
    static void Main(string []args)
    {
    //ENTRADA
        int val1, val2, prod;

        //leitura e conversão das váriaveis
        val1 = int.Parse(Console.ReadLine());
        val2 = int.Parse(Console.ReadLine());

    //PROCESSAENTO 
        prod = val1 * val2;

    //SAIDA
        Console.WriteLine("PROD = " + prod);
    }
}
/*ACEITO*/