using Estoque_Simples;
using System.Globalization;

Produto p1;

p1=new Produto();
Console.WriteLine("Entre com os dados do produto ");
Console.WriteLine("Nome:");
p1.Nome = Console.ReadLine();
Console.WriteLine("Preço:");
p1.Preco=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Quantidade no estoque:");
p1.Quantidade= int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do produto "+ p1);

Console.WriteLine();
Console.WriteLine("Digite o número de produtos a serem adicionados:");
int qtd = int.Parse(Console.ReadLine());
p1.AdicionarProdutos(qtd);

Console.WriteLine();
Console.WriteLine("Digite o número de produtos a serem removidos:");
 qtd = int.Parse(Console.ReadLine());
p1.RemoverProdutos(qtd);

Console.WriteLine("Dados atualizados: "+ p1);
