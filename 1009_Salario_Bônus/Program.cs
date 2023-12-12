using System;
//globalization por conta do CultureInfo.InvariantCulture
using System.Globalization;

//classe e seu nome
class Program{
    
    //metodo sem retorno
    static void Main(string[] args){
        
        //declaração de variaveis
        double salFixo, totVendas, comissao, resultado;
        string vendNome;

        //lendo a string
        vendNome = Console.ReadLine();

        /*convertendo os valores para double, lendo e 
            armazenando os valores que serão fornecidos pelo usuario*/
        salFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        totVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //fazendo a multiplicação da comissao que o funcionario ganha
        comissao = totVendas * 0.15;

        //obtendo o resultado final
        resultado = salFixo + comissao;

        Console.WriteLine("TOTAL = R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }
}
