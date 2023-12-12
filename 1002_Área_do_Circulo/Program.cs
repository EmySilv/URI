/*Um namespace permite a definição de estruturas, classes, 
funções, constantes, etc, que estarão vinculadas a ele.     NÃO SEI PQ ISSO TÁ AQUI, MAS TÁ*/
//importação
using System;
using System.Globalization;

// classe e seu nome
class Program{
    //método sem retorno
    static void Main(string[] args)
    {
    //ENTRADA
        double area, n, r;

        //atribuindo valor as variaveis e fazendo a conversão de strig para double
        n = 3.14159;
        r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                            /*delimita a quantidade de casas antes do ponto, no resultado final, 
                                            colocando apenas o dobro de casas do resultado inicial*/
    
    //PROCESSAMENTO
        area = (Math.Pow(r, 2)) * n;
            /*Math = biblioteca de matmatica. Pow = faz a potencia do numero indicado */
            
    //SAIDA
        /*.ToString basicamente colocando o valor em uma string*/    /*CultureInfo.InvariantCulture para manter o resultado com . ao invés de ,*/
        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
                                            /*o F4 determina quantas casa terão dps da virgula/ponto*/
    }
}
/*ACEITO*/
