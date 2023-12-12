using System;
//globalization por conta do CultureInfo.InvariantCulture
using System.Globalization;

//classe e seu nome
class Program{
    
    //metodo sem retorno
    static void Main(string[] args){
            
            //declaração de variaveis
            int v1, v2, v3, v4, dif;

            /*convertendo os valores para inteiro, lendo e 
            armazenando os valores que serão fornecidos pelo usuario*/
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            v3 = int.Parse(Console.ReadLine());
            v4 = int.Parse(Console.ReadLine());

            /*calculando a diferena dos valores e armazenando na variavel dif*/
            dif = (v1 * v2 - v3 * v4);

            Console.WriteLine("DIFERENCA = " + dif);
    }
}
