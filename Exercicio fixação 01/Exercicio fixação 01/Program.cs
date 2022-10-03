using Exercicio_fixação_01;
using System.Globalization;

Retangulo x;

x = new Retangulo();

Console.WriteLine("Insira a largura do retangulo:");
x.Largura=double.Parse(Console.ReadLine());
Console.WriteLine("Insira a altura do retangulo:");
x.Altura=double.Parse(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("Área:");
Console.WriteLine( x.Area());

Console.WriteLine("Perimetro:");
Console.WriteLine( x.Perimetro());

Console.WriteLine("Diagonal:");
Console.WriteLine(x.Diagonal());