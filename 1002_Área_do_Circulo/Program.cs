using System;
using System.Globalization;

class Program
{

    static void Main(string[] args) 
    { 

        double p, r, a;
        
        p = 3.14159;
        r = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        a = p * (r * r);
        
        Console.WriteLine("A=" + a.ToString("F4", CultureInfo.InvariantCulture));

        Console.ReadLine();
    }

}