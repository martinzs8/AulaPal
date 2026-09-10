int numero;
int cont = 1;

Console.Write("Digite um número: ");
numero= int.Parse(Console.ReadLine());

while (cont * 2 <= numero)
{
    Console.WriteLine(cont * 2);
    cont++;
}