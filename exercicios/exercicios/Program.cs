Console.WriteLine("Digte um valor:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Digite um segundo valor:");
int y = int.Parse(Console.ReadLine());  


if (x % y ==0 || y % x == 0) 
{
    Console.WriteLine($"{x} e {y}  são multiplos");
}
else
{
    Console.WriteLine($"{x} e {y}  não são multiplos ");
}