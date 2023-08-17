// See https://aka.ms/new-console-template for more information

int[] A = new int[10]; int[] B = new int[10]; int [] C = new int[10];
int count = 1;

for (int i = 0; i < A.Length; i++)
{
    Console.Write($"-- DIgite o {count}° número A:\n>> ");
    A[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"-- DIgite o {count}° número B:\n>> ");  
    B[i] = Convert.ToInt32(Console.ReadLine());
    count++;
}