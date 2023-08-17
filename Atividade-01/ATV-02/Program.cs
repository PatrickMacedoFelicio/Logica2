// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] semana = new int[7];
int temp = 1;

for (int i = 0; i < semana.Length; i++)
{
    Console.Write($"// Digite a {temp}° temperatura da semana:\n>> ");
    semana[i] = Convert.ToInt32(Console.ReadLine());
}
