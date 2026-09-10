int cont = 1;
string nome;
string sexo;

while (cont <= 15)
{
    Console.Write("Digite o nome: ");
nome = Console.ReadLine();

    Console.Write("Digite o sexo (F/M): ");
    sexo=(Console.ReadLine().ToLower());

    if (sexo == "m")
    {
        Console.WriteLine(nome +"  fazer o exame.");
  }
    if (sexo == "f")
    {
        Console.WriteLine(nome +  " não  fazer o exame.");
   }
    else
    {
        Console.WriteLine("Sexo digitado de forma incorreta");
  }


    cont++;
}