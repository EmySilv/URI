using System;
//globalization por conta do CultureInfo.InvariantCulture
using System.Globalization;

//classe e seu nome
class Program{
    
    //metodo sem retorno
    static void Main(string[] args){
            
            //declaração de variaveis
            double nota1, nota2, nota3, media;

            /*atribuição de valores*/                /*delimita as casas dpsdo ponto, sendo mostrado 
                                                    apenas o dobro de casa que foi inserda no inicio*/
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*fazendo a multiplicação e divisão dos valores.
            o peso dado no ex tem que ser multiplicado pela nota e de tudo tem que ser dividido pela soma dos pesos.*/ 
             media = (nota1 * 2 + nota2 * 3 + nota3 * 5) / 10;

            /*imprimindo valores na tela,
             além de coletar outros*/                       /*será definido ponto como objeto de separaão dos valores*/
           Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
                                                    //F1 é pra delimitar as casa dps do ponto
    }   
}
