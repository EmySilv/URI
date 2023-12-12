using System.Globalization;
using System;

class Program{
    static void Main(string[] args){

        Console.Clear();
        
        Console.WriteLine("Digite o valor: ");
        string[] grade = Console.ReadLine()!.Split(' ');

        double val1 = double.Parse(grade[0], CultureInfo.InvariantCulture);
        double val2 = double.Parse(grade[1], CultureInfo.InvariantCulture);
        double val3 = double.Parse(grade[2], CultureInfo.InvariantCulture);

        double delta = Math.Pow(val2, 2) - (4 * val1 * val3);

        double raiz1 = - (val2 + Math.Sqrt(delta)) / (2 * val1); 
        double raiz2 = - (val2 - Math.Sqrt(delta)) / (2 * val1);

        if(delta > 0 && val1 != 0){
            
            Console.WriteLine("R1 = " + raiz2.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + raiz1.ToString("F5", CultureInfo.InvariantCulture));
        } else{
            Console.WriteLine("Impossivel calcular");
        }
        
    }
}