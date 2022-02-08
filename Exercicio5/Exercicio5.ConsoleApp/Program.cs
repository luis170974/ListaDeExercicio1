using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Seja Bem vindo!");
                Console.WriteLine("###MENU###");
                Console.WriteLine("1. Fazer conta Salario Final");
                Console.WriteLine("2. Sair");

                opcao = Console.ReadLine();

                if (opcao != "1" && opcao != "2")
                {
                    Console.WriteLine("Opção Invalida");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (opcao == "2")
                {
                    break;
                }

                Console.WriteLine("Digite seu salario:");

                string strSalarioInicial = Console.ReadLine();

                double salarioInicial = System.Convert.ToDouble(strSalarioInicial);

                double resultadoSalarioAumen = 0;

                double resultadoSalarioDesc = 0;

                double salarioFinal = 0;


                if (opcao == "1")
                {
                    resultadoSalarioAumen = salarioInicial * 0.15;

                    resultadoSalarioDesc = resultadoSalarioAumen * 0.08;

                    salarioFinal = salarioInicial + resultadoSalarioAumen - resultadoSalarioDesc;
                }

                Console.WriteLine("Seu salario final:" + salarioFinal);

                Console.ReadLine();

                Console.Clear ();
            
            }
            while (opcao == "1");
            }
    }
}
