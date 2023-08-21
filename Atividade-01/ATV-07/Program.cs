// See https://aka.ms/new-console-template for more information

string[] semana = {"Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab"};
double[] temp = new double[7];

for (int i = 0; i < semana.Length; i++)
{
    Console.Write($"Digite a temperatura da semana:\n> {semana[i]}: ");
    temp[i] = Convert.ToDouble(Console.ReadLine());
}
    Console.Clear();
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-= Histograma Temperaturas =-=-=-=-=-=-=-=-=-=-=-");
for (int i = 0; i < semana.Length; i++)
{
    Console.Write($"\n> {semana[i]}: ");
    for (int j = 0; j < temp[i]; j++)
    {
        System.Threading.Thread.Sleep(30);
        Console.Write("■");
    }
    Console.Write($" - {temp[i]}°");
}