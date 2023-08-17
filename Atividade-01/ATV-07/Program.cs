// See https://aka.ms/new-console-template for more information

string[] semana = new string[7];
semana[0] = "D"; semana[1] = "S"; semana[2] = "T";semana[3] = "Q"; semana[4] = "Q"; semana[5] = "S"; semana[6] = "S";
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
}