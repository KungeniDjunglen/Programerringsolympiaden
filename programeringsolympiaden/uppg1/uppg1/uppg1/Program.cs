using System;

Console.Write("Ordet ? ");
string input = Console.ReadLine();
Console.Write("antal upprepningar ? ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    Console.Write(input);
}