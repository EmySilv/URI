using System;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            double salarioFixo, vendasEfetuadas, comissao, salarioFinal;
            string nome;
        
            nome = Console.ReadLine();

            salarioFixo = double.Parse(Console.ReadLine());

            vendasEfetuadas = double.Parse(Console.ReadLine());

            comissao = vendasEfetuadas * 0.15;

            salarioFinal = salarioFixo + comissao;

            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }