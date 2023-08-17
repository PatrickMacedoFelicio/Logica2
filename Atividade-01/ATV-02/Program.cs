// See https://aka.ms/new-console-template for more information

int[] temps = new int[7];
double media = 0;
int temp = 1, count = 0; ;

for (int i = 0; i < temps.Length; i++)
{
    Console.Write($"// Digite a {temp}° temperatura da semana:\n>> ");
    temps[i] = Convert.ToInt32(Console.ReadLine());

    media = media + temps[i];
    temp++;
    Console.Clear();
}
media = media / 7;
for (int i = 0; i < temps.Length; i++)
{
    if (temps[i] >= media)
        count++;
}
Console.WriteLine($">> No total |{count}| temperaturas foram maiores que a média\n" +
    $"Média: {Math.Round(media)}");
