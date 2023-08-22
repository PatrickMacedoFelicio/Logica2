// See https://aka.ms/new-console-template for more information

/*int tamanho = 10;

double[] A = new double[tamanho];
double[] B = new double[tamanho];
double[] C = new double[tamanho * 2];

// I) Preenchendo os vetores/arrays A e B
Console.Write("\r\n ┌────────────────────────────────────────┐");
Console.Write("\r\n │ União de 10 valores em ordem crescente │");
Console.Write("\r\n └────────────────────────────────────────┘\r\n");
Console.WriteLine("");

for (int i = 0; i < tamanho; i++)
{
    Console.Write(" Digite o valor para A" + (i + 1) + ": ");
    A[i] = Convert.ToDouble(Console.ReadLine());

    Console.Write(" Digite o valor para B" + (i + 1) + ": ");
    B[i] = Convert.ToDouble(Console.ReadLine());
}

// II) Criando o vetor/array C com as somas em ordem crescente
int numA = 0;
int numB = tamanho;

for (int i = 0; i < tamanho * 2; i++)
{
    if (numA < tamanho && (numB >= tamanho * 2 || A[numA] <= B[numB - tamanho]))
    {
        C[i] = A[numA];
        numA++;
    }
    else
    {
        C[i] = B[numB - tamanho];
        numB++;
    }
}

// III) Imprimindo os vetores/arrays A, B e C
Console.WriteLine("\r\n -----------------------------------------");

Console.Write("\r\n ┌────────────┐");
Console.Write("\r\n │ Resultados │");
Console.Write("\r\n └────────────┘\r\n");

Console.WriteLine(" \r\n Valores A (inseridos): " + string.Join(", ", A));
Console.WriteLine(" Valor B (inseridos): " + string.Join(", ", B));
Console.WriteLine(" Valor C (união em ordem crescente): " + string.Join(", ", C));

Console.WriteLine("");
Console.WriteLine("\r\n Pressione ENTER para finalizar.");
Console.WriteLine("\r\n -----------------------------------------");

Console.ReadKey();*/

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