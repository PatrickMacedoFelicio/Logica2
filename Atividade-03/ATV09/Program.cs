﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV09
{
    internal class Program
    {
        static double[] teste;
        static void Main(string[] args)
        {
            teste  = new double[30];

            for (int i = 0; i < teste.Length; i++)
            {
                Console.Write($"--Digite o {i+1}° Número:\n>> ");
                teste[i] = Convert.ToDouble(Console.ReadLine());
            }
            int esco;
            do
            {
                Console.WriteLine("\n-=-=-=-=-=-=- Escolha -=-=-=-=-=-=-");
                Console.Write("\n-- Escolha o que você deseja acessar:\n>> ");
                esco = Convert.ToInt32(Console.ReadLine());
                switch (esco)
                {
                    case 1:
                        ordem();
                        break;
                    case 2:
                        mult7();
                        break;
                    default:
                        Console.WriteLine("Escreva uma opção valida!");
                        break;
                }
                Console.ReadKey();

            } while (esco != 3); 
        }

        public static void ordem()
        {
            for (int i = 0; i < teste.Length - 1; i++)
            {
                for (int j = i + 1; j < teste.Length; j++)
                {
                    if (teste[i] > teste[j])
                    {
                        double aux = teste[i];
                        teste[i] = teste[j];
                        teste[j] = aux;
                    }
                }
            }
            Console.Write("\n-> Colocando os Números digitados em ordem ficam: ");
            for (int i = 0; i < teste.Length; i++)
            {
                Console.Write(teste[i] + " ");
            }
        }
        public static void mult7()
        {
            int count = 0;
            for (int i = 0; i < teste.Length; i++)
            {
                if (teste[i] % 7 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"\n\n-> Foram digitados {count} números multiplos por 7");
        }
    }
}
