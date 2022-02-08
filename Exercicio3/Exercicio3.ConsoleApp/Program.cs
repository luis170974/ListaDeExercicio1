using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcoes;
            do
            {
                Console.WriteLine("Seja Bem vindo");

                Console.WriteLine("###Menu###");
                Console.WriteLine("1. Calcular sua idade em formato de dias");
                Console.WriteLine("2. Sair");

                opcoes = Console.ReadLine();

                if(opcoes != "1" && opcoes != "2"){
                    Console.WriteLine("Não é possivel calcular");
                }
                
                if(opcoes == "2")
                {
                    break;
                }

                Console.WriteLine("Digite seu nome");

                String strNome = Console.ReadLine();

                Console.WriteLine("Digite sua idade");

                String strIdade = Console.ReadLine();

                int Idade = System.Convert.ToInt32(strIdade);

                int resultadoIdade = 0;

                if(opcoes == "1")
                {
                    resultadoIdade = Idade * 365;
                }

                Console.WriteLine("Sua idade em dias é:" + resultadoIdade);
                Console.ReadLine();
                Console.Clear();

            }
            while (opcoes == "1");
        }
    }
}
