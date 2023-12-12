using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double preco = 0;

        string[] line = Console.ReadLine().Split(' ');
        int codigo = int.Parse(line[0]);
        int qnt = int.Parse(line[1]);

        if (codigo == 1)
        {
            preco = 4.00;
        }
        else if (codigo == 2)
        {
            preco = 4.50;
        }
        else if (codigo == 3)
        {
            preco = 5.00;
        } 
        else if (codigo == 4)
        {
            preco = 2.00;
        }
        else if (codigo == 5)
        {
            preco = 1.50;
        }

        double total = qnt * preco;
        
        Console.WriteLine($"Total: R$ {total.ToString("F2")}");
    }
}