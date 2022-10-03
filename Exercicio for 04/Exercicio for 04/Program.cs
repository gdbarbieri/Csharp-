using System.Globalization;

Console.WriteLine("Insira o valor do N:");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    String[] line = Console.ReadLine().Split(' ');
    int x = int.Parse(line[0]); 
    int y = int.Parse(line[1]);

    if (y == 0)
    {
        Console.WriteLine("Divisão impossível!!");
    }
    else
    {
        double div = (double)x / y;
        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
    }
}