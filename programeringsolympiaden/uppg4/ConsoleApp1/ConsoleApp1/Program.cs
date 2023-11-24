using System;

Console.Write("Björnens protein ? ");
string Björnen = Console.ReadLine();
Console.Write("k ? ");
int k = int.Parse(Console.ReadLine());

char[] chars = Björnen.ToCharArray();

List<float> list = new List<float>();

int NumsInARow = 0;
for (int i = 0; i < chars.Length; i++)
{
    if (chars[i] != 'l')
    {
        NumsInARow++;
    }
    else if (chars[i] == 'l')
    {
        list.Add(NumsInARow);
        NumsInARow = 0;
    }
}
list.Add(NumsInARow);

double Svar = 0;

for (int i = 0;i < list.Count; i++)
{
    Svar += Math.Ceiling(list[i] / k);
}
Console.WriteLine("Svar: " +  Svar);