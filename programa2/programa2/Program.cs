Console.WriteLine("Entre com o seu nome completo:");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto:");
float produto=float.Parse(Console.ReadLine());

Console.WriteLine("Entre seu último nome, idade e altura");
string[] v = Console.ReadLine().Split(' ');
string nome1 = v[0];
int idade= int.Parse(v[1]);
float alt= float.Parse(v[2]);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(produto);
Console.WriteLine(nome1);
Console.WriteLine(idade);
Console.WriteLine(alt);
