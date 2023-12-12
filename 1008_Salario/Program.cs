using System;
//globalization por conta do CultureInfo.InvariantCulture
using System.Globalization;

//classe e seu nome
class Program{
    
    //metodo sem retorno
    static void Main(string[] args){
        
        //declaração de variaveis
        double salario, numHora, valorHora;
        int numFuncionario;

        /*convertendo os valores para inteiro, lendo e 
            armazenando os valores que serão fornecidos pelo usuario*/
        numFuncionario = int.Parse(Console.ReadLine());  
                                                /*delimita as casas dpsdo ponto, sendo mostrado 
                                                apenas o dobro de casa que foi inserda no inicio*/
        numHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //multiplicando os valores
        salario = valorHora * numHora;

        //mostrando o nmr do funcionario
        Console.WriteLine("NUMBER = " + numFuncionario);

        //mostrando o salario do funcionario
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}
