﻿using System;
using System.Globalization;
using System.Numerics;

Console.WriteLine("Insira o valor de n:");
int n = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double[] vect = new double[n];

for (int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

}
double sum = 0.0;
for(int i = 0; i < n; i++)
{
    sum += vect[i];
}
double avg = sum / n;
Console.WriteLine("AVERAGE HEIGHT = "+avg.ToString("F2",CultureInfo.InvariantCulture));


