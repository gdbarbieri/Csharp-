Console.WriteLine("Digite uma coordenada:");
int x=int.Parse(Console.ReadLine());

Console.WriteLine("Digite outra coordenada");
int y=int.Parse(Console.ReadLine());
if (y == 0.0)
{
    Console.WriteLine("Eixo X");
}
else if (x > 0.0 && y > 0.0)
{
    Console.WriteLine("Q1");
}
else if (x < 0.0 && y > 0.0)
{
    Console.WriteLine("Q2");
}
else if (x < 0.0 && y < 0.0)
{
    Console.WriteLine("Q3");
}
else
{
    Console.WriteLine("Q4");
}

    while (x != 0 && y != 0)
    {
        Console.WriteLine("Digite uma coordenada:");
         x = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outra coordenada");
         y = int.Parse(Console.ReadLine());
          if (y == 0.0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x > 0.0 && y > 0.0)
        {
            Console.WriteLine("Q1");
        }
        else if (x < 0.0 && y > 0.0)
        {
            Console.WriteLine("Q2");
        }
        else if (x < 0.0 && y < 0.0)
        {
            Console.WriteLine("Q3");
        }
        else
        {
            Console.WriteLine("Q4");
        } 
    }