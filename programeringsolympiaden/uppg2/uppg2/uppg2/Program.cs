using System;

Console.Write("N ? ");
int HighestNumber = int.Parse(Console.ReadLine());
int Svar = 0;


for (int i = 1; i < HighestNumber; i++)
{
    float num = i * (i + 1) * (i + 2);
    if(num < HighestNumber)
    {
        if (Math.Truncate(num) == num) // Kollar om det finns en decimal
        {
            Svar++;
        }
    }
}

Console.WriteLine("Svar: " + Svar);