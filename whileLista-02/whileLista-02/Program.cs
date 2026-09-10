int cont = 1;
int numero;
int soma = 0;

while (cont <= 5)
{
    Console.Write("Digite um número: ");
    numero = int.Parse(Console.ReadLine());

    soma = soma + numero;
    cont++;
}
Console.WriteLine("O resultado da soma é" + soma);

