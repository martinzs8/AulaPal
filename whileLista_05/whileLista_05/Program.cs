int cont = 1;
int anonasc;
int anoatual;
int idade;

Console.Write("Digite o ano atual: ");
anoatual = int.Parse(Console.ReadLine());

while (cont <= 4)
{
    Console.Write("Digite o ano de nascimento da pessoa " + cont + ": ");
    anonasc = int.Parse(Console.ReadLine());

    idade = anoatual - anonasc;

    Console.WriteLine("A idade da pessoa " + cont + " é: " + idade);
    cont++;
}