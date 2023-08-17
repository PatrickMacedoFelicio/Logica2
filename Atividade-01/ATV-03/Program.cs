// See https://aka.ms/new-console-template for more information

string[] meses = new string[12];
double[] altura = new double[10];
int count = 1;
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\nEscolha ");
Console.Write("[1] Vogais\n[2] Alturas\n[3] Meses do Ano\n\n>> ");
int escolha = Convert.ToInt32(Console.ReadLine());
Console.Clear();

switch (escolha)
{
	case 1:
        Console.Write("Deseja escrever quantas Vogais?\n>> ");
        int esc = Convert.ToInt32(Console.ReadLine());
        string[] vogais = new string[esc];
        for (int i = 0; i < vogais.Length; i++)
        {
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("Digite a Vogal: ");
            vogais[i] = Console.ReadLine();
        }
        break;
    case 2:
        for (int i = 0; i < altura.Length; i++)
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write($"Digite a altura da {count}° pessoa: ");
            altura[i] = Convert.ToDouble(Console.ReadLine());
            count++;
        }
        break;
    case 3:
        for (int i = 0; i < meses.Length; i++)
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write($"Digite o {count}° mês do ano:\n>> ");
            meses[i] = Console.ReadLine();
            count++;
        }
        break;
}