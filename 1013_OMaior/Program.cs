using System;
//globalization por conta do CultureInfo.InvariantCulture

//classe e seu nome
class Program{

    //metodo sem retorno
    static void Main(string[] args){
        // declaração de valores
        int valor1, valor2, valor3, maior;

        //criação de um array de nome 'linha1'
        string[] linha1 = Console.ReadLine()!.Split(' ');
                                            // .Split (' ')  divide uma string em vários pedaços, 
                                            // transformando em um array, ele basuicamente descarta esse espaço que digitamos

        // convertendo os valores e determinando seu lugar na lista
        valor1 = int.Parse(linha1[0]);
        valor2 = int.Parse(linha1[1]);
        valor3 = int.Parse(linha1[2]);

        // making os calculos
        maior = (valor1 + valor2 + Math.Abs(valor1 - valor2)) / 2;

        // making a condição de decisão, caso o valor se encaixe é impresso no console a mensagem de baixo  
        if(maior > valor3) {
            Console.WriteLine(maior + " eh o maior");
        } else { // senão jogado para o ELSE
            Console.WriteLine(valor3 + " eh o maior");
        }

    }
}