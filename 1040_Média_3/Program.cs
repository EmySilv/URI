using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        string[] line = Console.ReadLine().Split(' ');
        double nota1 = double.Parse(line[0], CultureInfo.InvariantCulture);
        double nota2 = double.Parse(line[1], CultureInfo.InvariantCulture);
        double nota3 = double.Parse(line[2], CultureInfo.InvariantCulture);
        double nota4 = double.Parse(line[3], CultureInfo.InvariantCulture);

        double mediaNota = ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / 10;

        if (mediaNota >= 7.0) {
            Console.WriteLine($"Media: {mediaNota.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno aprovado.");
        } else if (mediaNota < 5.0) {
            Console.WriteLine($"Media: {mediaNota.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno reprovado.");
        } else {
            Console.WriteLine($"Media: {mediaNota.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno em exame.");
            double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double mediaFinal = (mediaNota + exame) / 2;
            Console.WriteLine($"Nota do exame: {exame.ToString("F1", CultureInfo.InvariantCulture)}");
            if (mediaFinal >= 5.0) {
                Console.WriteLine("Aluno aprovado.");
            } else {
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}