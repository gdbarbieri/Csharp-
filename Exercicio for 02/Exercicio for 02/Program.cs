﻿Console.WriteLine("Insira o valor de N: ");
int N =int.Parse(Console.ReadLine());

int fat = 1;
for(int i = 1; i <= N; i++)
{
    fat = fat * i;
}
Console.WriteLine(fat);