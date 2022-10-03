using Exercicio_de_FIxação_02;
using System.Globalization;

Funcionario x;
x = new Funcionario();

Console.WriteLine("Insira o nome do funcionário:");
x.Nome = Console.ReadLine();

Console.WriteLine("");
Console.WriteLine("Insira o salario bruto:");
x.SalarioBruto=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("");
Console.WriteLine("Insira o Imposto:");
x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Funcionário: {x.Nome}, $ {x.SalarioLiquido()} ");

Console.WriteLine("");
Console.WriteLine("Digite a porcentagem para aumentar o salário :");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.AumentarSalario(porcentagem);


Console.WriteLine($"Funcionário: {x} ");