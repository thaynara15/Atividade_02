using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atividade_02
{
     class Program
    {
        static void Main(string[] args)

        {
            //////Atividade_01
            //Console.Write("Insira um número: ");
            //int numero = Convert.ToInt16(Console.ReadLine());

            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine("O Número é PAR");
            //}
            //else
            //{
            //    Console.WriteLine("O Número é IMPAR");
            //}

            //Console.ReadKey();



            //////Atividade_02
            //Console.WriteLine("Quantos clientes deseja cadastrar: ");
            //int numeroClientes = Convert.ToInt16(Console.ReadLine());

            //string[] clientes = new string[numeroClientes];


            //for (int i =0; i < clientes.Length; i++)
            //{
            //    Console.Write("Informe um nome: ");
            //    clientes[i] = Console.ReadLine();

            //}

            //Console.WriteLine("\n-------------------------\n");
            //Console.ForegroundColor = ConsoleColor.Yellow;

            //for (int i = 0; i < clientes.Length; i++)
            //{
            //    Console.WriteLine(clientes[i]);


            //}

            //Console.ReadKey();




            //////Atividade_03
            //double[] vetorNumeros = new double[5];
            //double maior = 0, menor = 0;

            //for (int i = 0; i < vetorNumeros.Length; i++)
            //{
            //    Console.Write("Informe um número: ");
            //    vetorNumeros[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //maior = vetorNumeros[0];
            //menor = vetorNumeros[0];

            //for (int i = 0; i < vetorNumeros.Length; i++)
            //{

            //    if (vetorNumeros[i] > maior)
            //    {
            //        maior = vetorNumeros[i];
            //    }

            //    if (vetorNumeros[i] < menor)
            //    {
            //        menor = vetorNumeros[i];
            //    }

            //}
            //Console.WriteLine("\n");
            //Console.ForegroundColor = ConsoleColor.Red;

            //Console.WriteLine(string.Format("Maior: {0} | Menor: {0}"));

            //Console.ReadKey();


            //////Atividade_04
            //int[,] matNumeros = new int[4, 4]
            //{
            //    {0,0,0,1},
            //    {0,0,0,1},
            //    {0,0,0,2},
            //    {0,0,0,1},
            //};

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(string.Format("[{0}] ", matNumeros[i, j]));
            //    }
            //    Console.WriteLine("\n");
            //}

            //Console.ReadKey();


            char operacao;

            Console.WriteLine("..:MENU:..");
            Console.WriteLine("Selecione uma operação ou pressione 's' para sair");
            Console.WriteLine("+ = Adição");
            Console.WriteLine("- = Subtrção");
            Console.WriteLine("* = Multiplicãção");
            Console.WriteLine("/ = Divisão");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nEntre com uma operação: ");

            char.TryParse(Console.ReadLine(), out operacao);

            double num1, num2;

            while (operacao != 's')
            {
                switch (operacao)
                {
                    case '+':
                        Console.Write("Informe o 1º número: ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.Write("Informe o 2º número: ");
                        double.TryParse(Console.ReadLine(), out num2);

                        Console.WriteLine("{0} {1} {2} = {3}", num1, operacao, num2, (num1 + num2));

                        break;

                    case '-':
                        Console.Write("Informe o 1º número: ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.Write("Informe o 2º número: ");
                        double.TryParse(Console.ReadLine(), out num2);

                        Console.WriteLine("{0} {1} {2} = {3}", num1, operacao, num2, (num1 - num2));

                        break;

                    case '*':
                        Console.Write("Informe o 1º número: ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.Write("Informe o 2º número: ");
                        double.TryParse(Console.ReadLine(), out num2);

                        Console.WriteLine("{0} {1} {2} = {3}", num1, operacao, num2, (num1 * num2));

                        break;

                    case '/':
                        Console.Write("Informe o 1º número: ");
                        double.TryParse(Console.ReadLine(), out num1);
                        Console.Write("Informe o 2º número: ");
                        double.TryParse(Console.ReadLine(), out num2);

                        Console.WriteLine("{0} {1} {2} = {3}", num1, operacao, num2, (num1 / num2));

                        break;
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nPressione uma tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("..:MENU:..");
                Console.WriteLine("Selecione uma operação ou pressione 's' para sair");
                Console.WriteLine("+ = Adição");
                Console.WriteLine("- = Subtrção");
                Console.WriteLine("* = Multiplicãção");
                Console.WriteLine("/ = Divisão");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nEntre com uma operação: ");

                char.TryParse(Console.ReadLine(), out operacao);
            }
        }
    }
}
