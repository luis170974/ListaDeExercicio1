using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcao;

            do
            {
                Console.WriteLine("A melhor Imobiliaria é Imóbilis");

                Console.WriteLine("### SEJA BEM VINDO ###");

                Console.WriteLine("Digite 1 para calcular seu terreno");

                Console.WriteLine("Digite 2 para sair");

                opcao = Console.ReadLine();

                if(opcao != "1" && opcao != "2")
                {
                    Console.WriteLine("Não é possivel executar essa ação!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (opcao == "2")
                {
                    break;
                }

                Console.WriteLine("Digite a base do terreno");

                String strBaseNumero = Console.ReadLine();

                Console.WriteLine("Digite a altura do terreno");

                String strAlturaNumero = Console.ReadLine();

                double baseNumero = System.Convert.ToDouble(strBaseNumero);

                double alturaNumero = System.Convert.ToDouble(strAlturaNumero);

                double area = 0;

                if (opcao == "1")
                {
                    if (baseNumero == 0 || alturaNumero == 0)
                    {
                        Console.WriteLine("Você nao pode ter um terreno com essas dimensões!");
                        Console.ReadLine();
                        Console.Clear ();
                        continue;
                    }

                    else {
                        area = baseNumero * alturaNumero;
                    }
                }


                Console.Write("O resultado é : " + area);
                Console.ReadLine();
                Console.Clear();

            }
            while (opcao == "1");

        }
    }
}
