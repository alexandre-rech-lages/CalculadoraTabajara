using System;
using System.Collections.Generic;

namespace CalculadoraTabajara.ConsoleApp
{
    class Program
    {
        //1º Deve realizar operações de adição
        //2º Deve realizar operações de subtração
        //3º Deve realizar operações de multiplicação
        //4º Deve realizar operações de divisão
        //5º Deve visualizar operações realizadas

        static List<string> calculos = new List<string>();
        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {
                #region Menu Principal

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela Principal\n");

                Console.WriteLine("Digite 1 para realizar operações de Adição\n");

                Console.WriteLine("Digite 2 para realizar operações de Subtração\n");

                Console.WriteLine("Digite 3 para realizar operações de Multiplicação\n");

                Console.WriteLine("Digite 4 para realizar operações de Divisão\n");

                Console.WriteLine("Digite 5 para visualizar as operações feitas\n");

                Console.WriteLine("Digite S para sair\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
                {
                    Console.WriteLine("Por favor, digite uma opção válida!");
                    Console.ReadLine();
                    continue;
                }

                if (opcao == "5")
                {
                    foreach (var c in calculos)
                    {
                        Console.WriteLine(c);
                    }
                    Console.ReadLine();
                    continue;
                }

                #endregion

                #region Realizar Calculo

                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                string operacao = "", simbolo = "";

                switch (opcao)
                {
                    case "1": operacao = "Adição"; simbolo = "+"; break;

                    case "2": operacao = "Subtração"; simbolo = "-"; break;

                    case "3": operacao = "Multiplição"; simbolo = "*"; break;

                    case "4": operacao = "Divisão"; simbolo = "/"; break;

                    default:
                        break;
                }

                string subtitulo = $"Novo calculo de {operacao}";

                Console.WriteLine(subtitulo + "\n");

                Console.Write($"Digite o primeiro número: ");
                double primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Digite o segundo número: ");
                double segundoNumero = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;

                    case "2": resultado = primeiroNumero - segundoNumero; break;

                    case "3": resultado = primeiroNumero * segundoNumero; break;

                    case "4": resultado = primeiroNumero / segundoNumero; break;

                    default:
                        break;
                }
                #endregion

                #region Mostrar Resultado
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara\n");

                Console.WriteLine("Tela de Resultados\n");

                Console.Write($"O resultado da operação da {operacao} é: {resultado}");

                string descricaoCalculo = primeiroNumero + " " + simbolo + " " + segundoNumero + " = " + resultado; 
                
                calculos.Add(descricaoCalculo);

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();
                #endregion
            }
        }
    }
}
