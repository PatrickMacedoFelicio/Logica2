// See https://aka.ms/new-console-template for more information

int count = 1, tam = 5;
int[] A = new int[tam]; int[] B = new int[tam]; int [] C = new int[A.Length + B.Length];

for (int i = 0; i < A.Length; i++)
{
    Console.Write($"-- DIgite o {count}° número A:\n>> ");
    A[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"-- DIgite o {count}° número B:\n>> ");  
    B[i] = Convert.ToInt32(Console.ReadLine());
    count++;
    C[i] = A[i];
}
for (int i = 0; i < A.Length; i++)
{
    for (int j = 0; j < B.Length; j++)
    {
        if (C[i] == B[j])
            C[(A.Length + B.Length)+i] = B[j];
    }
}
for (int i = 0; i < C.Length; i++)
{
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.Write(C[i]+", ");
}