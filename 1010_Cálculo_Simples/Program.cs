using System;
using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            double codigo1, unidade1, preçoUnidade1, codigo2, unidade2, precoUnidade2, total;

            codigo1 = double.Parse(Console.ReadLine());

            unidade1 = double.Parse(Console.ReadLine());

            preçoUnidade1 = double.Parse(Console.ReadLine());

            codigo2 = double.Parse(Console.ReadLine());

            unidade2 = double.Parse(Console.ReadLine());

            precoUnidade2 = double.Parse(Console.ReadLine());

            total = codigo1 + unidade1 + preçoUnidade1 / codigo2 + unidade2 + precoUnidade2;

            Console.WriteLine("VALOR A PAGAR = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }