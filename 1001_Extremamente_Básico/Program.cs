    //importação
using System; 

//classe principal
class Program
{
    //metodo principal, sem retorno
    static void Main(string[] args)
    { 
    //ENTRADA  
        int a, b, x;
        
        //leitura e conversão de variaveis
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
    
    //PROCEESSAMENTO
        x = a + b;
        
    //SAIDA DE DADOS
        Console.WriteLine("X = " + x);

    }

}