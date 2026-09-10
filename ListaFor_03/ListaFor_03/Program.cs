int num = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());

    if (num % 4 == 0)
    {
        Console.WriteLine("O número " + num + " é múltiplo de 4");
    }
}