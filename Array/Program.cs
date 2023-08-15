// See https://aka.ms/new-console-template for more information

Console.Write("Qual será a quantidade de alunos para dar notas?\n>> ");
int tam = Convert.ToInt32(Console.ReadLine());
Console.Clear();

string[] nomeAluno = new string[tam];
double[] nota1 = new double[tam];
double[] nota2 = new double[tam];
double[] media = new double[tam];

for (int i = 0; i < nomeAluno.Length; i++)
{
    Console.Write("\nDigite o nome do aluno:\n>> ");
    nomeAluno[i] = Console.ReadLine();
    Console.Write("Digite a 1º nota:\n>> ");
    nota1[i] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite a 2º nota:\n>> ");
    nota2[i] = Convert.ToDouble(Console.ReadLine());

    media[i] = (nota1[i]+nota2[i])/2;
}
    Console.Clear();

for (int i = 0;i < nomeAluno.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Calculando notas");
    for (int j = 0; j < 50; j++)
    {
        System.Threading.Thread.Sleep(30);
        Console.Write(".");
    }
    Console.WriteLine();
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine("A nota do aluno: " + nomeAluno[i]);
    Console.WriteLine("Nota 01: " + nota1[i]);
    Console.WriteLine("Nota 02: " + nota2[i]);
    Console.WriteLine("A sua média é: " + media[i]);
    if (media[i] >= 60){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Está APROVADO");
    }
    else{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Está REPROVADO");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
}
