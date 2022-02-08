using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menuOpcao;
            do
            {
                Console.WriteLine("Bem vindo A Padaria Hotpao");
                Console.WriteLine("Digite 1 para calcular a quantidade vendida");
                Console.WriteLine("Digite 2 para sair");

                menuOpcao = Console.ReadLine();

                if(menuOpcao != "1" && menuOpcao != "2")
                {
                    Console.WriteLine("Digite uma tecla disponivel");
                    Console.Clear();
                    continue;
                }


                if (menuOpcao == "1")
                {
                    Console.WriteLine("Qual a quantidade de Pães vendidos?");

                    string strPaesVendidos = Console.ReadLine();

                    Console.WriteLine("Qual a quantidade de Broas vendidas?");

                    string strBroasVendidas = Console.ReadLine();

                    double paesVendidos = System.Convert.ToDouble(strPaesVendidos);

                    double broasVendidas = System.Convert.ToDouble(strBroasVendidas);

                    double resultadoVendas = paesVendidos * 0.12 + broasVendidas * 1.50;

                    double guardarPoupanca = resultadoVendas * 0.1;

                    Console.WriteLine("O total de Paes e Broas é: R$" + resultadoVendas);

                    Console.WriteLine("Voce deve Guardar em uma conta poupança : R$ " + guardarPoupanca);
                    
                    Console.ReadLine();
                    
                    Console.Clear();
                }

                if (menuOpcao == "2")
                {
                    break;
                }
            }
            while (menuOpcao == "1");
        }
    }
}
