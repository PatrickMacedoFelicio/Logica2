// See https://aka.ms/new-console-template for more information

int[] A = new int[10]; int[] B = new int[10]; int[] C = new int[10];
int count = 1, tam = 9;

for (int i = 0; i < A.Length; i++)
{
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.Write($"Digite o {count}° numero para A:\n>> ");
    A[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Digite o {count}° numero para B:\n>> ");
    B[i] = Convert.ToInt32(Console.ReadLine());
    count++;
    //Console.Clear();
}
Console.WriteLine("-=-=-=-=-=-=-=-=- A soma de A e B -=-=-=-=-=-=-=-=-\n");
for (int i = 0; i < A.Length; i++)
{
    C[i] = A[i] + B[tam];
    Console.WriteLine($"> Soma de A[{A[i]}] + B[{B[tam]}] = C[{C[i]}]");
    tam--;
}