using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV03
{
    internal class Program
    {
        static int escolha1, escolha2, op;
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=- Converção de Moedas -=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("\t\t(Cotação do dia 17/09/2023)\n\n- Selecione a primeira moeda:");
                Console.Write("\n[1] Real\n[2] Dolar\n[3] Libra\n[4] Franco\n[5] Iene\n>> ");
                escolha1 = Convert.ToInt32(Console.ReadLine());

                switch (escolha1)
                {
                    // REAL
                    case 1:
                        Console.WriteLine("\n-{ REAL }-\n- Selecione a moeda para converter:");
                        Console.Write("\n[1] Dolar\n[2] Libra\n[3] Franco\n[4] Iene\n>> ");
                        escolha2 = Convert.ToInt32(Console.ReadLine());
                        switch (escolha2)
                        {
                            //Dolar
                            case 1:
                                Real_Dolar();
                                break;
                            //Libra
                            case 2:

                                break;
                            //Franco
                            case 3:

                                break;
                            //Iene
                            case 4:
                            default:
                                Console.WriteLine("Selecione uma opção valida");
                                break;
                        }
                        break;

                    // DOLAR
                    case 2:
                        Console.WriteLine("\n-{ DOLAR }-\n- Selecione a moeda para converter:");
                        Console.Write("\n[1] Real\n[2] Libra\n[3] Franco\n[4] Iene\n>> ");
                        escolha2 = Convert.ToInt32(Console.ReadLine());
                        switch (escolha2)
                        {
                            //REAL
                            case 1:
                                Real_Dolar();
                                break;
                            //Libra
                            case 2:

                                break;
                            //Franco
                            case 3:

                                break;
                            //Iene
                            case 4:
                            default:
                                Console.WriteLine("Selecione uma opção valida");
                                break;
                        }
                        break;
                        break;

                    // LIBRA
                    case 3:

                        break;

                    // FRANCO
                    case 4:

                        break;

                    // IENE
                    case 5:

                        break;

                    default:
                        Console.WriteLine("Selecione uma opção valida");
                        break;
                }
                Console.Write("\n-- Deseja sair?\n[1] SIM\n[2] NÃO\n>> ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (op != 1);
        }

        // CLASSES

        public static void Real_Dolar()
        {
            double real = 0, dolar = 0, resultado = 0;
            switch (escolha1)
            {
                case 1:
                    Console.Write("\n-- Digite o valor do REAL:\n>> ");
                    real = Convert.ToDouble(Console.ReadLine());
                    resultado = real * 0.21;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ REAL --> DOLAR}-");
                    Console.WriteLine($"\nR$ {real} = US$ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.Write("\n-- Digite o valor em DOLAR:\n>> ");
                    dolar = Convert.ToDouble(Console.ReadLine());
                    resultado = dolar * 4.87; 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ DOLAR --> REAL}-");
                    Console.WriteLine($"\nUS$ {dolar} = R$ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}
