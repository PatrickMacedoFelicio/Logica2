using System;

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
                        Real();
                        break;
                    // DOLAR
                    case 2:
                        Console.WriteLine("\n-{ DOLAR }-\n- Selecione a moeda para converter:");
                        Console.Write("\n[1] Real\n[2] Libra\n[3] Franco\n[4] Iene\n>> ");
                        escolha2 = Convert.ToInt32(Console.ReadLine());
                        Dolar();
                        break;

                    // LIBRA
                    case 3:
                        Console.WriteLine("\n-{ LIBRA }-\n- Selecione a moeda para converter:");
                        Console.Write("\n[1] Real\n[2] Dolar\n[3] Franco\n[4] Iene\n>> ");
                        escolha2 = Convert.ToInt32(Console.ReadLine());
                        Libra();
                        break;

                    // FRANCO
                    case 4:
                        Console.WriteLine("\n-{ FRANCO }-\n- Selecione a moeda para converter:");
                        Console.Write("\n[1] Real\n[2] Dolar\n[3] Libra\n[4] Iene\n>> ");
                        escolha2 = Convert.ToInt32(Console.ReadLine());
                        Franco();
                        break;

                    // IENE
                    case 5:
                        Console.WriteLine("\n-{ IENE }-\n- Selecione a moeda para converter:");
                        Console.Write("\n[1] Real\n[2] Dolar\n[3] Libra\n[4] Franco\n>> ");
                        escolha2 = Convert.ToInt32(Console.ReadLine());
                        Iene();
                        break;

                    default:
                        Console.WriteLine("Selecione uma opção valida");
                        break;
                }
                Console.Write("\n\n-- Deseja sair?\n[1] SIM\n[2] NÃO\n>> ");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (op != 1);
        }

        // CLASSES

        public static void Real()
        {
            double real = 0, resultado = 0;
            switch (escolha2)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ REAL --> DOLAR}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do REAL:\n>> ");
                    real = Convert.ToDouble(Console.ReadLine());
                    resultado = real * 0.21;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nR$ {real} = US$ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ REAL --> LIBRA}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do REAL:\n>> ");
                    real = Convert.ToDouble(Console.ReadLine());
                    resultado = real * 0.17;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nR$ {real} = £ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ REAL --> FRANCO}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do REAL:\n>> ");
                    real = Convert.ToDouble(Console.ReadLine());
                    resultado = real * 0.18;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nR$ {real} = Fr {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ REAL --> IENE}-");
                    Console.ForegroundColor = ConsoleColor.White;   
                    Console.Write("\n-- Digite o valor do REAL:\n>> ");
                    real = Convert.ToDouble(Console.ReadLine());
                    resultado = real * 30.36;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nR$ {real} = ¥ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public static void Dolar()
        {
            double dolar = 0, resultado = 0;
            switch (escolha2)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ DOLAR --> REAL}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do DOLAR:\n>> ");
                    dolar = Convert.ToDouble(Console.ReadLine());
                    resultado = dolar * 4.87;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nUS$ {dolar} =  R${resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ DOLAR --> LIBRA}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do DOLAR:\n>> ");
                    dolar = Convert.ToDouble(Console.ReadLine());
                    resultado = dolar * 0.81;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nUS$ {dolar} =  £ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ DOLAR --> FRANCO}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do DOLAR:\n>> ");
                    dolar = Convert.ToDouble(Console.ReadLine());
                    resultado = dolar * 0.90;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nUS$ {dolar} =  Fr {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ DOLAR --> IENE}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do DOLAR:\n>> ");
                    dolar = Convert.ToDouble(Console.ReadLine());
                    resultado = dolar * 147.74;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nUS$ {dolar} =  ¥ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public static void Libra()
        {
            double libra = 0, resultado = 0;
            switch (escolha2)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ LIBRA --> REAL}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor da LIBRA:\n>> ");
                    libra = Convert.ToDouble(Console.ReadLine());
                    resultado = libra * 6.03;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n£ {libra} = R$ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ LIBRA --> DOLAR}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor da LIBRA:\n>> ");
                    libra = Convert.ToDouble(Console.ReadLine());
                    resultado = libra * 1.24;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n£ {libra} = US$ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ LIBRA --> FRANCO}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor da LIBRA:\n>> ");
                    libra = Convert.ToDouble(Console.ReadLine());
                    resultado = libra * 1.11;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n£ {libra} = Fr {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ LIBRA --> IENE}-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor da LIBRA:\n>> ");
                    libra = Convert.ToDouble(Console.ReadLine());
                    resultado = libra * 183.11;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n£ {libra} = ¥ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public static void Franco()
        {
            double franco = 0, resultado = 0;
            switch (escolha2)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ FRANCO --> REAL }-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do FRANCO:\n>> ");
                    franco = Convert.ToDouble(Console.ReadLine());
                    resultado = franco * 5.43;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nFr {franco} = R$ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ FRANCO --> DOLAR }-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do FRANCO:\n>> ");
                    franco = Convert.ToDouble(Console.ReadLine());
                    resultado = franco * 1.11;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nFr {franco} = US$ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ FRANCO --> LIBRA }-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do FRANCO:\n>> ");
                    franco = Convert.ToDouble(Console.ReadLine());
                    resultado = franco * 0.90;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nFr {franco} = £ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ FRANCO --> IENE }-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do FRANCO:\n>> ");
                    franco = Convert.ToDouble(Console.ReadLine());
                    resultado = franco * 164.68;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nFr {franco} = ¥ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        public static void Iene()
        {
            double iene = 0, resultado = 0;
            switch (escolha2)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ IENE --> REAL }-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do IENE:\n>> ");
                    iene = Convert.ToDouble(Console.ReadLine());
                    resultado = iene * 0.033;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n¥ {iene} = R$ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ IENE --> DOLAR }-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do IENE:\n>> ");
                    iene = Convert.ToDouble(Console.ReadLine());
                    resultado = iene * 0.0068;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n¥ {iene} = US$ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ IENE --> LIBRA }-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do IENE:\n>> ");
                    iene = Convert.ToDouble(Console.ReadLine());
                    resultado = iene * 0.0055;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n¥ {iene} = £ {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n-{ IENE --> FRANCO }-");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n-- Digite o valor do IENE:\n>> ");
                    iene = Convert.ToDouble(Console.ReadLine());
                    resultado = iene * 0.0061;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n¥ {iene} = Fr {resultado}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}
