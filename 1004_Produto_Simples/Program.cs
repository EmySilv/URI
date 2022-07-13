using System;

    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = a * b;

           Console.WriteLine("PROD = " + c);

           Console.ReadLine();
        }
    }