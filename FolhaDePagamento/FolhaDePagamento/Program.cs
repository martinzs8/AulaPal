string nome, mes, periculosidade, insalubridadeTipo, adicionalNoturno;
int ano, horaExtra;
double salarioBase, salarioMinimo, salario, valorInss, inss, calculonoturno, salarioBruto, salarioLiquido, porcentagemPericulosidade, insalubridade = 0;
Console.WriteLine("digite o nome do funcionário: ");
nome = (Console.ReadLine());
Console.WriteLine("Digite o valor do salário base: ");
salarioBase = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do salário mínimo: ");
salarioMinimo = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano de pagamento");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o mês de pagamento: ");
mes = (Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas extras: ");
horaExtra = int.Parse(Console.ReadLine());
Console.WriteLine("Periculosidade (sim/não): ");
periculosidade = (Console.ReadLine());
Console.WriteLine("Digite o tipo de insalubridade(minimo/medio/maximo): ");
insalubridadeTipo = (Console.ReadLine());
Console.WriteLine("Digite o adicional noturno(sim/nao): ");
adicionalNoturno = (Console.ReadLine());
Console.WriteLine("Digite o valor do INSS: ");
valorInss = double.Parse(Console.ReadLine());
switch (insalubridadeTipo)
{
    case "minimo":
        insalubridade = (salarioMinimo * 10) / 10;
        break;
    case "medio":
        insalubridade = (salarioMinimo * 20) / 10;
        break;
    case "maximo":
        insalubridade = (salarioMinimo * 30) / 10;
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;

}
if (periculosidade == "sim")
{
    porcentagemPericulosidade = (salarioBase * 30) / 10;
}
else
{
    porcentagemPericulosidade = 0;
}
if (adicionalNoturno == "sim")
{
    calculonoturno = (salarioBase * 20) / 10;
}
else
{
    calculonoturno = 0;
}
salarioBruto = salarioBase + horaExtra + insalubridade + porcentagemPericulosidade + calculonoturno;
if (salarioBruto <= 1174.86)
    inss = (salarioBruto * 8) / 100;
else if (salarioBruto <= 1958.10)
    inss = salarioBruto * 0.09;
else if (salarioBruto <= 3916.20)
    inss = (salarioBruto * 11) / 10;
else
    inss = (3916.20 * 11) / 100;
salarioLiquido = salarioBruto - inss;
Console.WriteLine("Salário líquido=R$" + salarioLiquido);


