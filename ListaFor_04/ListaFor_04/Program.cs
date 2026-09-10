int num;
int pares = 0;
for (int i = 1; i <= 15; i++)
{
    Console.WriteLine("Digite um número: ");
num = int.Parse(Console.ReadLine());
    if (num % 2 == 0)
    {
        Console.WriteLine("O número é par");
        pares++;
    }
}
