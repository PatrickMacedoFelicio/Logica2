using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV02
{
    internal class Program
    {
        static double[] numeros;
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=- Atividade 02 -=-=-=-=-=-=-=-");
            Console.Write("\n-- Quantos números serão digitados?\n>> ");
            int qtdNum = Convert.ToInt32(Console.ReadLine());
            numeros = new double[qtdNum];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"\n-- Digite o {i+1}° número:\n>> ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());
            }
            //Console.Clear();            
            menuItens();
        }

        public static void ordenar()
        {
            // ORDENAR
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        double aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} ");
            }
        }
            
        public static void pares()
        {
            // PARES
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write($"{numeros[i]} ");
                }
            }
        }

        public static void mult5()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 5 == 0)
                {
                    Console.Write($"{numeros[i]} ");
                }
            }
        }

        public static void menuItens()
        {
            int op;
            do
            {
                Console.WriteLine("\n-=-=-=-=-=-=-=- Selecione! -=-=-=-=-=-=-=-");
                Console.Write("\nSelecione a opção que você deseja acessar:\n\n[1] Ver os números digitados em ordem Crescente\n[2] Números digitados Pares" +
                    "\n[3] Números digitados Multiplos de 5\n\n[4] Sair\n\n>> ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-=-=-=-=-=- Ordem Crescente -=-=-=-=-=-\n");
                        Console.Write("Os números digitados em ordem ficam: ");
                        ordenar();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-=-=-=-=-=- Números Pares -=-=-=-=-=-\n");
                        Console.Write("Esses números digitados são par: ");
                        pares();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-=-=-=-=-=- Números Múltiplos de 5 -=-=-=-=-=-\n");
                        Console.Write("Esses números digitados são multiplos de 5: ");
                        mult5();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n--> Digite uma opção válida.");
                        Console.ForegroundColor = ConsoleColor.White; 
                        break;
                }
            } while (op != 4);
        }
    }
}
