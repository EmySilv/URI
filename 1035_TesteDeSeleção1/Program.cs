using System;

//classe e seu nome
class Program
{
    static void Main()
    {
        int valorA, valorB, valorC, valorD;

        string[] linha1 = Console.ReadLine()!.Split(' ');
        valorA = int.Parse(linha1[0]);
        valorB = int.Parse(linha1[1]);
        valorC = int.Parse(linha1[2]);
        valorD = int.Parse(linha1[3]);

        //&& siginifa 'E', & não faço ideia
        if ((valorB > valorC) && (valorD > valorA) && (valorC + valorD) > (valorA + valorB) && (valorC > 0) && (valorD > 0) && (valorA % 2) == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}
