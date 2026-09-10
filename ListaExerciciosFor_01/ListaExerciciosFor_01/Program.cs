int numero;
int qtdpos = 0;
int qtdneg = 0;
for(int i=1; i<=10;  i++)
{ 
    Console.WriteLine("Digite um número qualquer: ");
    numero=int.Parse(Console.ReadLine());
    if(numero>0)
    {
        qtdpos++;
    }
    else
    {
        qtdneg++;
    }
}
Console.WriteLine("A quantidade de números positivos são: " + qtdpos);
Console.WriteLine("A quantidade de números negativos são: " + qtdneg);
