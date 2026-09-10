int cont = 1;
int valor;

while (cont <= 3)
{
    Console.Write("Digite um valor: ");
    valor = int.Parse(Console.ReadLine());

    Console.WriteLine("Resultado: " + (valor * 6));

    cont++;
}
