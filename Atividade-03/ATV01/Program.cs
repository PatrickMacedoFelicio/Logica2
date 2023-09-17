using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=- Atividade 01 -=-=-=-=-=-=-=-=-=-");
            Console.Write("\nDigite o primeiro número\n>> ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o segundo número\n>> ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite o terceiro número\n>> ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            ordemCrescente(num1, num2, num3);
            
        }
        public static void ordemCrescente(double num1, double num2, double num3)
        {
            double aux = 0;
            if (num1 > num2){
                aux = num1;
                num1 = num2;
                num2 = aux;
            }
            if (num1 > num3){
                aux = num1;
                num1 = num3;
                num3 = aux;
            }
            if (num2 > num3)
            {
                aux = num2;
                num2 = num3;
                num3 = aux;
            }
            Console.WriteLine($"\n>> Os números ordenando em Crescente ficam: {num1}, {num2}, {num3}");
            Console.ReadKey();
        }
    }
}
