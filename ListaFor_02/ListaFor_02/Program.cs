int numero = 0, qtd = 0 ;
for (int num = 1; num <= 300; num++)
{
    if (num % 3 == 0) 
    {

        Console.WriteLine(num);
        qtd++;
    }
}
Console.WriteLine("A quantidade de números que são multiplos de 3 é:"+qtd);
