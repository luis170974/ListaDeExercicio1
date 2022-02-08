using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcionais;
            do
            {
                Console.WriteLine("Bem-vindo");
                Console.WriteLine("Conversor De Celsius para Farenheit");

                Console.WriteLine("1. Converter de Celsius para Farenheit");
                Console.WriteLine("2. Converter de Farenheit para Celsius");
                Console.WriteLine("3. Sair");

                opcionais = Console.ReadLine();

                if (opcionais != "1" && opcionais != "2" && opcionais != "3")
                {
                    Console.WriteLine("Não é possivel calcular");
                }

                if (opcionais == "3")
                {
                    break;
                }


                double resultadoFarenheit = 0;

                if (opcionais == "1")
                {
                    Console.Write("Digite quantos graus celsius:");

                    string strCelsius = Console.ReadLine();

                    double Celsius = System.Convert.ToDouble(strCelsius);

                    resultadoFarenheit = Celsius * 1.8 + 32;

                    Console.Write("O resultado da conversão em Farenheit é:" + resultadoFarenheit);
                }
                else if(opcionais == "2")
                {
                    Console.WriteLine("Digite quantos Farenheit");

                    string strFarenheit = Console.ReadLine();

                    double Farenheit = System.Convert.ToDouble(strFarenheit);

                    resultadoFarenheit = Farenheit - 32 * 1.8;

                    Console.Write("O resultado da conversão em Celsius é:" + resultadoFarenheit);
                }

                
                Console.ReadLine();
                Console.Clear();
            }
            while (opcionais == "1" || opcionais == "2");  
        }
    }
}
