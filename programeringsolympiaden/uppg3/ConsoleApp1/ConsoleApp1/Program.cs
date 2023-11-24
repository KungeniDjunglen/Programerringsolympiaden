using System;


Console.Write("N ? ");
int Rader = int.Parse(Console.ReadLine());
Console.Write("M ? ");
int kolumner = int.Parse(Console.ReadLine());

char[,] chars = new char[Rader, kolumner];

for (int i = 0; i < Rader; i++)
{
    Console.Write("Rad " + (i+1) + " ? ");
    string input = Console.ReadLine();
    char[] inputs = input.ToCharArray();
    for (int j = 0; j < inputs.Length; j++)
    {
        chars[i, j] = inputs[j];
    }
}

string Answear = "";
int x= 0;

for (int i = 0; i < Rader ; i++)
{
    for (int j = 0; j < kolumner; j++)
    {
        if (chars[i, j] != '.' && x <= j)
        {
            Answear += chars[i, j];
            x = j;
        }
    }
}

Console.Write(Answear);