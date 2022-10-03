Console.WriteLine("Digite um valor:");
int x = int.Parse(Console.ReadLine());
if (x >0 && x < 25)
{
    Console.WriteLine("Intervalo (0-25)");
}
if (x >25  && x <50)
{
    Console.WriteLine("Intervalo (25-50)");
}
if (x > 50 && x < 75)
{
    Console.WriteLine("Intervalo (50-75)");
}
if (x > 75 && x < 100)
{
    Console.WriteLine("Intervalo (75-100)");
}