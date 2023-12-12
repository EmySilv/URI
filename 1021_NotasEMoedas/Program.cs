using System;
using System.Globalization;
//globalization por conta do CultureInfo.InvariantCulture

//classe e seu nome
class Program
{
    static void Main()
    {
        Console.Clear();
        double valor;
        double[] cedulas = { 100, 50, 20, 10, 5, 2, 1, 0.50, 0.25, 0.10, 0.05, 0.01 };
        double[] resultados = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        valor = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        Console.WriteLine(valor);
        for (int i = 0; i < cedulas.Length; i++)
        {
            if (valor / cedulas[i] > 0)
            {
                resultados[i] = (valor / cedulas[i]);
                valor = (valor % cedulas[i]);
            }
            else
            {
                resultados[i] = 0;
            }

            if (resultados[i] > 1)
            {
                resultados[i] = Convert.ToInt32(resultados[i]);
                Console.WriteLine(resultados[i] + " nota(s) de R$ " + cedulas[i] + ".00", CultureInfo.InvariantCulture);
            }
            else
            {
                resultados[i] = Convert.ToInt32(resultados[i]);
                Console.WriteLine(resultados[i] + " nota(s) de R$ " + cedulas[i], CultureInfo.InvariantCulture);
            }

        }
    }
}