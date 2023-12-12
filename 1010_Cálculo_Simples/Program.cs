using System;
//globalization por conta do CultureInfo.InvariantCulture
using System.Globalization;

//classe e seu nome
class Program{
    
    //metodo sem retorno
    static void Main(string[] args){
        
        //declaração de variaveis
        double preçoUnidade1, precoUnidade2;
        double total;
        int codigo1, codigo2, unidade1, unidade2;

        //leitura e conversão de valores
        string[] linha1 = Console.ReadLine().Split(' ');
        codigo1 = Convert.ToInt32(linha1[0]);
        unidade1 = Convert.ToInt32(linha1[1]);
        preçoUnidade1 = double.Parse(linha1[2], CultureInfo.InvariantCulture);
        //leitura e conversão de valores
        string[] linha2 = Console.ReadLine().Split(' ');
        codigo2 = Convert.ToInt32(linha2[0]);
        unidade2 = Convert.ToInt32(linha2[1]);
        precoUnidade2 = double.Parse(linha2[2], CultureInfo.InvariantCulture);

        // multiplicação e soma dos valores
         total = (unidade1 * preçoUnidade1) + (unidade2 * precoUnidade2);

        // imprimindo o valor no console
         Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",  CultureInfo.InvariantCulture));
    }
}

