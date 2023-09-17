using System.Xml;

Console.WriteLine("-=-=-=-=-=-=-=-=-=- Atividade 02 -=-=-=-=-=-=-=-=-=-=");
Console.Write("-- Escolha\n[1] Notas Disciplinar do Aluno\n[2] Quantitativo de Gados\n>> ");
int esc = Convert.ToInt32(Console.ReadLine());

switch (esc)
{
	case 1:
		Console.Write("-- Serão cadastrados quantos alunos?\n>> ");
		int qtdAlunos = Convert.ToInt32(Console.ReadLine());
		string[] nomeAlu = new string [qtdAlunos];
        string[][] disciplinas = new string[qtdAlunos][];
        double[][] notasAlu = new double[qtdAlunos][];

        for (int i = 0; i < qtdAlunos; i++)
		{
            Console.Write($"\n-- Qual é o nome do {i+1}° Aluno\n>> "); 
			nomeAlu[i] = Console.ReadLine();
			Console.Write($"\n-- Quantas disciplinas {nomeAlu[i]} terá?\n>> ");
            int qtdDisc = Convert.ToInt32(Console.ReadLine());

			for (int j = 0; i < qtdDisc; j++)
			{
                Console.Write($"\n-- Qual é o nome da {j+1}° disciplina do aluno {nomeAlu[i]}?\n>> ");
				disciplinas[i][j] = Console.ReadLine();
				Console.Write($"\n-- Qual é a nota de {nomeAlu[i]} para a disciplina de {disciplinas[i][j]}?\n>> ");
            }
        }
		break;
	case 2:

		break;
	default:
		Console.WriteLine("\nEssa opção não existe. Por favor escolha uma opção válida.");
		break;
}