using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=- Números Divisiveis -=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("-- Digite o Primeiro número:\n>> ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("-- Digite o Segundo número:\n>> ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Divisiveis(num1, num2);
            Console.ReadKey();
        }

        public static void Divisiveis(double num1, double num2)
        {
            if (num1 % num2 == 0)
            {
                Console.Write($"\nO número {num1} é divisivel por {num2}.");
            }
            else
            {
                Console.Write($"\nO número {num1} não é divisivel por {num2}.");
            }
        }
    }
}
