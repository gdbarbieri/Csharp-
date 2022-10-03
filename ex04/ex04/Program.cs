Console.WriteLine("Insira o seu salário:");
double salario= double.Parse(Console.ReadLine());
double imposto = 0;

if (salario > 0.00 && salario <= 2000.0)
{
    Console.WriteLine("Isento");
}
else if (salario >= 2000.01 && salario <= 3000.00)
{
    imposto = salario * 0.08;
    Console.WriteLine($"O valor do imposto será de {imposto} R$");
}
else if (salario >= 3000.01 && salario <= 4500.00)
{
    imposto = 1000 * 0.08 + 0.18 * 2.00;
    Console.WriteLine($"O valor do imposto será de {imposto} R$");
}
else if(salario > 4.500)
{
    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
    Console.WriteLine($"O valor do imposto será de {imposto} R$");
}
else
{
    Console.WriteLine("Salário inválido");
}