using EscolaTudoBem;
using static System.Console;
using static System.Convert;

Aluno novo = null, inicio = null, lista = null, aux = null;

int op = 0;
do
{
    WriteLine("-=-=-=-=-=-=- Escola Tudo Bem -=-=-=-=-=-=-");
    Write("Selecione uma opção:\n[1] Cadastrar Aluno\n[2] Consultar Alunos\n[3] Listar Todos os Alunos e salvar\n>> ");
    op = ToInt32(ReadLine());
    Clear();
    WriteLine("-=-=-=-=-=-=- Escola Tudo Bem -=-=-=-=-=-=-");
    switch (op)
    {
        case 1:
            novo = new Aluno();
            Write("\n- Digite o NOME do Aluno:\n>> ");
            novo.nome = ReadLine();
            Write("\n- Digite o MATRÍCULA do Aluno:\n>> ");
            novo.matricula = ReadLine();
            Write("\n- Digite o CURSO do Aluno:\n>> ");
            novo.curso = ReadLine();

            //GRADE
            Grade grade = new Grade();
            Write("\n- Quantas Disciplinas o Aluno terá?\n>> ");
            int qtd = ToInt32(ReadLine());
            grade.disciplina = new string[qtd];
            grade.notas = new double[qtd,4];

            WriteLine("\n-=-=-=-=-=-=- Grade do ALUNO -=-=-=-=-=-=-");
            for (int i = 0; i < qtd; i++)
            {
                Write($"\n-NOME da {i+1}° disciplina:\n>> ");
                grade.disciplina[i] = ReadLine();
                WriteLine("\n->> NOTAS");

                for (int j = 0; j < 4; j++)
                {
                    Write($"\n- {j+1}° Nota: ");
                    grade.notas[i,j] = ToDouble(ReadLine());
                }
            }
            mediaDisc(grade.disciplina, grade.notas);
            novo.grade = grade;

            WriteLine("\nClique em qualquer tecla para voltar ao MENU...");
            ReadKey();
            Clear();

            //ENCADEAMENTO
            if (inicio == null)
            {
                inicio = novo;
                inicio.prox = null;
            }
            else
            {
                if (inicio.prox == null)
                {
                    lista = novo;
                    inicio.prox = lista;
                    lista.prox = null;
                }
                else
                {
                    lista.prox = novo;
                    lista = novo;
                    lista.prox = null;
                }
            }
            break;

        case 2:
            aux = inicio;
            Write("\n- Deseja fazer a CONSULTA por:\n[1] Nome\n[2] Matrícula\n>> ");
            int op1 = ToInt32(ReadLine());
            switch (op1)
            {
                case 1:
                    Write("\n- Digite o NOME para consultar:\n>> ");
                    string nome = ReadLine().ToLower();
                    bool veri = false;
                    while (aux != null)
                    {
                        if (aux.nome.ToLower() == nome)
                        {
                            WriteLine($"\nNome: {aux.nome}");
                            WriteLine($"Nome: {aux.matricula}");
                            WriteLine($"Nome: {aux.curso}");
                            for (int i = 0; i < aux.grade.disciplina.Length; i++)
                            {
                                WriteLine($"{i+1}° Disciplina: {aux.grade.disciplina[i]}");
                            }
                            veri = true;
                            break;
                        }
                        else
                        {
                            veri = false;
                        }
                        aux = aux.prox;
                    }
                    if (veri == false)
                    {
                        WriteLine("\nNão foi encontrado nada.\n");
                    }
                    break;

                case 2:
                    Write("\n- Digite a MATRICULA para consultar:\n>> ");
                    string matricula = ReadLine().ToLower();
                    bool veri2 = false;
                    while (aux != null)
                    {
                        if (aux.matricula.ToLower() == matricula)
                        {
                            WriteLine($"\nNome: {aux.nome}");
                            WriteLine($"Matricula: {aux.matricula}");
                            WriteLine($"Curso: {aux.curso}");
                            for (int i = 0; i < aux.grade.disciplina.Length; i++)
                            {
                                WriteLine($"{i + 1}° Disciplina: {aux.grade.disciplina[i]}");
                            }
                            WriteLine("");
                            veri2 = true;
                            break;
                        }
                        else
                        {
                            veri2 = false;
                        }
                        aux = aux.prox;
                    }
                    if (veri2 == false)
                    {
                        WriteLine("\nNão foi encontrado nada.\n");
                    }
                    break;

                default:
                    WriteLine("\nEssa opção NÃO existen\nClique em qualquer tecla para voltar ao MENU...");
                    ReadKey();
                    Clear();
                    break;
            }
            break;

        case 3:
            aux = inicio;

            while (aux != null)
            {
                WriteLine($"\nNome: {aux.nome}");
                WriteLine($"Nome: {aux.matricula}");
                WriteLine($"Nome: {aux.curso}");
                for (int i = 0; i < aux.grade.disciplina.Length; i++)
                {
                    WriteLine($"{i + 1}° Disciplina: {aux.grade.disciplina[i]}");
                }
                WriteLine("");
                aux = aux.prox;
            }

            string caminhho = @"C:\Users\Public\escola.txt";

            using (StreamWriter sw = new StreamWriter(caminhho))
            {
                aux = inicio;
                while (aux != null)
                {
                    sw.WriteLine($"\nNome: {aux.nome}");
                    sw.WriteLine($"Nome: {aux.matricula}");
                    sw.WriteLine($"Nome: {aux.curso}");
                    for (int i = 0; i < aux.grade.disciplina.Length; i++)
                    {
                        sw.WriteLine($"{i + 1}° Disciplina: {aux.grade.disciplina[i]}");
                    }
                    sw.WriteLine("");
                    aux = aux.prox;
                }
            }

            break;
        default:
            WriteLine("\nEssa opção NÃO existen\nClique em qualquer tecla para voltar ao MENU...");
            ReadKey();
            Clear();
            break;
    }

} while (op != 0);

static void mediaDisc(string[] nomeDisc ,double[,] notas)
{
    double[] medias = new double[nomeDisc.Length];
    WriteLine("");
    for (int i = 0; i < nomeDisc.Length; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            medias[i] = notas[i, j] + medias[i];
        }
        WriteLine($"- {nomeDisc[i]} -> Média: {medias[i] / 4}");
    }
}