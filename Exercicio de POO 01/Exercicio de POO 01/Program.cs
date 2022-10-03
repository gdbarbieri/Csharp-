using Exercicio_de_POO_01;

Pessoa p1, p2;

p1 = new Pessoa();
p2 = new Pessoa();

Console.WriteLine("Insira os dados da primeira pessoa :");
Console.WriteLine("nome:");
p1.Nome = Console.ReadLine();
Console.WriteLine("idade:");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Insira os dados da segunda pessoa :");
Console.WriteLine("nome:");
p2.Nome = Console.ReadLine();
Console.WriteLine("idade:");
p2.Idade = int.Parse(Console.ReadLine());
 
if(p1.Idade > p2.Idade)
{
    Console.WriteLine(p1.Nome);
}
else
{
    Console.WriteLine(p2.Nome);
}
