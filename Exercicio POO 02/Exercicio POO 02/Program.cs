using Exercicio_POO_02;
using System.Globalization;
using System.Security.Cryptography;

Funcionario f1, f2;

f1 = new Funcionario();
f2 = new Funcionario();

Console.WriteLine("Informe os dados do primeiro funcionário:");
Console.WriteLine("Nome:");
f1.Nome = Console.ReadLine();
Console.WriteLine("Salário:");
f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Informe os dados do segundo  funcionário:");
Console.WriteLine("Nome:");
f2.Nome = Console.ReadLine();
Console.WriteLine("Salário:");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double media = (f1.Salario + f2.Salario) / 2;

Console.WriteLine("Média entre os salários: " + media);
