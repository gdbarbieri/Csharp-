﻿using exemplo;
using System.Globalization;
using System.Transactions;

Triangulo x, y;
x= new Triangulo();
y = new Triangulo();
Console.WriteLine("Entre com os valores do triângulo X:" );
x.A= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
x.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com os valores do triângulo Y:");
y.A= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double areaX = x.Area();


double areaY = y.Area();

Console.WriteLine("Área de x = "+ areaX.ToString("F4",CultureInfo.InvariantCulture));

Console.WriteLine("Áera de y = "+ areaY.ToString("F4",CultureInfo.InvariantCulture));

if(areaX > areaY)
{
    Console.WriteLine("Maior área = X");
}
else
{
    Console.WriteLine("Maior Área = Y");
}
