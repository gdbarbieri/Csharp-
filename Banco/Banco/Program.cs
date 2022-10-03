using Banco;
using System.Globalization;

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.Write("Entre com o nome do titular:");
string titular = Console.ReadLine();

Console.Write("Haverá depósito inicial   (s/n)? ");
char op = char.Parse(Console.ReadLine());

if(op == 's' || op == 'S')
{
    Console.Write("Entre o valor do deposito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
   conta= new ContaBancaria(numero, titular, depositoInicial);
}
else
{
    conta = new ContaBancaria(numero, titular);
}
Console.WriteLine();
Console.WriteLine("Dados da conta");
Console.WriteLine(conta);

Console.WriteLine();
Console.WriteLine("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.WriteLine("Entre um valor para saque: ");
 quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);