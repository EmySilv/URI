using System;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            double valorHora, quantidadeHora, resultado;
            int nmr;

            nmr = int.Parse(Console.ReadLine());

            valorHora = double.Parse(Console.ReadLine());

            quantidadeHora = double.Parse(Console.ReadLine());

            resultado = valorHora * quantidadeHora;

            Console.WriteLine("NUMBER = " + nmr);

            Console.WriteLine("SALARY = U$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.ReadLine();
        }
    }