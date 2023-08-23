// See https://aka.ms/new-console-template for more information

int tam = 10, numA = 0, numB = tam, count = 1;
int[] A = new int[tam], B = new int[tam], C = new int[tam*2];

Console.WriteLine("-=-=-=-=-=-=-=-=-=-=- União de 10 Números em Ordem Crescente -=-=-=-=-=-=-=-=-=-=-=");

for (int i = 0; i < tam; i++)
{
    Console.Write($"\n- Digite o valor do {count}º número de A: ");
    A[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"- Digite o valor do {count}º número de A: ");
    B[i] = Convert.ToInt32(Console.ReadLine());
    count++;
}

for (int i = 0; i < tam*2; i++)
{
    if (numA < tam && (numB >= tam * 2 || A[numA] <= B[numB-tam])){
        C[i] = A[numA];
        numA++;
    }else{
        C[i] = B[numB - tam];
        numB++;
    }
}

Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=- União de 10 Números em Ordem Crescente -=-=-=-=-=-=-=-=-=-=-=\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("- Os valores inseridos em A foram: ");
Console.ForegroundColor = ConsoleColor.White;
for (int i = 0; i < A.Length; i++)
{
    Console.Write($"{A[i]}, ");
}
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\n- Os valores inseridos em B foram: ");
Console.ForegroundColor = ConsoleColor.White;
for (int i = 0; i < B.Length; i++)
{
    Console.Write($"{B[i]}, ");
}
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\n- A união dos Valores colocado em C na ordem crescete é: ");
Console.ForegroundColor = ConsoleColor.White;
for (int i = 0; i < C.Length; i++)
{
    Console.Write($"{C[i]}, ");
}