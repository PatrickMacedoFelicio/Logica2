
int v1 = 0, v2 = 0;
double soma = 0;
Console.Write("Digite um Número\n>> ");
v1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digitee o segundo Número\n>> ");
v2 = Convert.ToInt32(Console.ReadLine());

soma = Soma(v1,v2);
Console.WriteLine(soma);

static double Soma(double x, double y)
{
    double res = 0;
    res = x + y;
    return res;
}