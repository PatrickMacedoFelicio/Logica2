using PROVAEX;
using static System.Console;
using static System.Convert;

Cliente novo = null, inicio = null, lista = null, aux = null;
int op = 0;
do
{
    WriteLine("-=-=-=-=-=-=-=-=- Academia Modelo -=-=-=-=-=-=-=-=-");
    Write("Selecione uma opção:\n[1] Cadastrar Cliente\n[2] Consultar Cliente\n[3] Listar todos os clientes\n>> ");
    op = ToInt32(ReadLine());
    Clear();
    WriteLine("-=-=-=-=-=-=-=-=- Academia Modelo -=-=-=-=-=-=-=-=-");
    switch (op)
    {
        case 1:
            novo = new Cliente();
            Write("\n- Código do Cliente:\n>> ");
            novo.codigo = ToInt32(ReadLine());
            Write("\n- Nome:\n>> ");
            novo.nome = ReadLine();
            Write("\n- Peso:\n>> ");
            novo.peso = ToDouble(ReadLine());
            Write("\n- Sexo:\n>> ");
            novo.sexo = ReadLine();
            Write("\n- Idade:\n>> ");
            novo.idade = ToInt32(ReadLine());

            Write("\n- Quantos Exercicios o Cliente terá?\n>> ");
            int qtd = ToInt32(ReadLine());

            Exercicios ex = new Exercicios();
            ex.aparelho = new string[qtd];
            ex.calorias = new double[qtd];

            WriteLine("-=-=-=-=-=-=-=-=- Exercicios -=-=-=-=-=-=-=-=-");
            for (int i = 0; i < qtd; i++)
            {
                Write($"\n-{i+1}º Aparelho do Exercicio:\n>> ");
                ex.aparelho[i] = ReadLine();
                Write($"\n-{i+1}° Calorias perdidas do Exerciocio:\n>> ");
                ex.calorias[i] = ToDouble(ReadLine());
            }

            calorGast(ex.calorias);

            novo.exercicios = ex;

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
            int a = 0;
            Write("\nDeseja Consultar por:\n[1] Código\n[2] Nome\n>> ");
            a = ToInt32(ReadLine());

            switch (a)
            {
                case 1:
                    Write("\n- Digite o CÓDIGO do Cliente:\n>> ");
                    int co = ToInt32(ReadLine());
                    bool veri = false;
                    while (aux != null)
                    {
                        if (aux.codigo.Equals(co))
                        {
                            Write($"\n> Código do Cliente: {aux.codigo}");
                            Write($"\n> Código do Cliente: {aux.nome}");
                            Write($"\n> Código do Cliente: {aux.peso}");
                            Write($"\n> Código do Cliente: {aux.sexo}");
                            Write($"\n> Código do Cliente: {aux.exercicios.aparelho}");
                            Write($"\n> Código do Cliente: {aux.exercicios.calorias}");
                            veri = true;
                            break;
                        }
                        else
                        {
                            veri = false;
                        }
                    }
                    if (veri == false)
                    {
                        WriteLine("\n- Não foi encontrado nada!");
                        WriteLine("Aperte qualquer tecla para voltar...");
                        ReadKey();
                        Clear();
                    }
                    break;
                case 2:
                    Write("- Digite o NOME do Cliente:\n>> ");
                    string nome = ReadLine().ToLower();
                    bool veri2 = false;
                    while (aux != null)
                    {
                        if (aux.nome.ToLower() == nome)
                        {
                            Write($"\n> Código do Cliente: {aux.codigo}");
                            Write($"\n> Código do Cliente: {aux.nome}");
                            Write($"\n> Código do Cliente: {aux.peso}");
                            Write($"\n> Código do Cliente: {aux.sexo}");
                            Write($"\n> Código do Cliente: {aux.exercicios.aparelho}");
                            Write($"\n> Código do Cliente: {aux.exercicios.calorias}");
                            veri2 = true;
                            break;
                        }
                        else
                        {
                            veri2 = false;
                        }
                    }
                    if (veri2 == false)
                    {
                        WriteLine("\n- Não foi encontrado nada!");
                        WriteLine("Aperte qualquer tecla para voltar...");
                        ReadKey();
                        Clear();
                    }
                    break;
            }
            break;

        case 3:
            aux = inicio;
            int count = 0;
            while (aux != null)
            {
                Write($"\n> Código do Cliente: {aux.codigo}");
                Write($"\n> Nome do Cliente: {aux.nome}");
                Write($"\n> Peso do Cliente: {aux.peso}");
                Write($"\n> Sexo do Cliente: {aux.sexo}");
                WriteLine($"\n> Idade do Cliente: {aux.idade}");

                for (int i = 0; i < aux.exercicios.aparelho.Length; i++)
                {
                    WriteLine($"{i+1}° Aparelho usado pelo Cliente: {aux.exercicios.aparelho[i]}");
                    WriteLine($"{i + 1}° Calorias perdidas no Exercicio:{aux.exercicios.calorias[i]}");
                }

                WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-\n");

                aux = aux.prox;
                count += 1;
            }
            WriteLine($"\nForam cadastrados <{count}> Clientes na academia!");

            WriteLine("\nAperte qualquer tecla para voltar ao MENU...");
            ReadKey();
            Clear();

            string path = @"C:\Users\Public\academia.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                aux = inicio;
                while (aux != null)
                {
                    sw.WriteLine($"{aux.codigo}");
                    sw.WriteLine($"{aux.nome}");
                    sw.WriteLine($"{aux.peso}");
                    sw.WriteLine($"{aux.sexo}");
                    sw.WriteLine($"{aux.idade}");
                    sw.WriteLine($"{aux.sexo}");

                    for (int i = 0; i < aux.exercicios.aparelho.Length; i++)
                    {
                        sw.WriteLine($"{aux.exercicios.aparelho[i]}");
                        sw.WriteLine($"{aux.exercicios.calorias[i]}");
                    }

                    aux = aux.prox;
                }

            }

            break;

        default:
            Write("\nEssa opção NÃO Existe\nAperte qualquer tecla para voltar...");
            ReadKey();
            Clear();
            break;
    }
} while (op != 0);

static void calorGast(double[] calorias)
{
    double soma = 0;
    for (int i = 0; i < calorias.Length; i++)
    {
        soma = calorias[i] + soma;
    }
    WriteLine($"\n- Foram gastos ao total <{soma}> calorias!\n");
}