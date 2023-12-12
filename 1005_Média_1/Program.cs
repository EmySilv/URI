using System;
//globalization por conta do CultureInfo.InvariantCulture
using System.Globalization;

//classe e seu nome
class Program{
    
    //metodo sem retorno
    static void Main(string[] args)
    {
    //ENTRADA        
            double nota1, nota2, media;

                                                   /*delimita as casas dpsdo ponto, sendo mostrado 
                                                    apenas o dobro de casa que foi inserda no inicio*/
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            
    //PROCESSAMENTO
            media = (nota1 * 3.5 + nota2 * 7.5) / 11; 
            /*obs: o peso que é dado no exercicio tem que ser multiplicado pela nota e a somatoria dos pesos tem que ser o divisor*/

    //SAIDA                      
           Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
                                                    //F5 é pra delimitar as casa dps do ponto
    }   
}
