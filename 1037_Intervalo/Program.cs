using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double res = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        if (res >= 0 && res <= 25)
        {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (res > 25 && res <= 50)
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (res > 50 && res <= 75)
        {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (res > 75 && res <= 100)
        {
            Console.WriteLine("Intervalo (75,100]");
        } else {
            Console.WriteLine("Fora de intervalo");
        }
    }
}
