using System;
using System.Globalization;
//globalization por conta do CultureInfo.InvariantCulture

//classe e seu nome
class Program
{

    //metodo sem retorno
    static void Main(string[] args)
    {
        int idadeDias, ano, mes, dia;

        idadeDias = int.Parse(Console.ReadLine()!);

        ano = idadeDias / 365;
        idadeDias = idadeDias % 365;

        mes = idadeDias / 30;
        idadeDias = idadeDias % 30;

        dia = idadeDias;

        Console.WriteLine($"{ano} ano(s)");
        Console.WriteLine($"{mes} mes(es)");
        Console.WriteLine($"{dia} dia(s)");
    }
}