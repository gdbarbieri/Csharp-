Console.WriteLine("Digite a coordenada de x ,em decimal:");
float x= float.Parse(Console.ReadLine());

Console.WriteLine("Digite a coordenada de y, em decimal:");
float y= float.Parse(Console.ReadLine());

if( x ==0 && y==0)
{
    Console.WriteLine("Origem");
}
else if(x>=0 && y < 0)
{
    Console.WriteLine("Q4");
}
else if(x>0 && y>0)
{
    Console.WriteLine("Q1");
}
else if (x <0 && y > 0)
{
    Console.WriteLine("Q2");

}
else if (x <0  && y < 0)
{
    Console.WriteLine("Q3");
}