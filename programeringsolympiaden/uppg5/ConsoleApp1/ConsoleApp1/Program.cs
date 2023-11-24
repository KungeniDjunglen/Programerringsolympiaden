using System;

Console.Write("Antalet byggnader ? ");
int NumBuilds = int.Parse(Console.ReadLine());
Console.Write("Kostnaden av Megapicklen ? ");
int MegaCost = int.Parse(Console.ReadLine());

int[,] Buildings = new int[NumBuilds, 2];

for (int i = 0; i < NumBuilds; i++)
{
    Console.Write("Produktionshastighet och pris för byggnad " + (i+1) + " ? ");
    string input = Console.ReadLine();

    string[] temp = input.Split(' ');
    Buildings[i,0] = int.Parse(temp[0]);
    Buildings[i,1] = int.Parse(temp[1]);
}

//Setup för spelet
bool HasWon = false;
int Svar = 0;
int Pickles = 0;
List<int> list = new List<int>();
list.Add(0);

while (!HasWon)
{
    Svar++;
    foreach (int i in list) //inkomst
    {
        Pickles += Buildings[list[i], 0];
    }
    if(Pickles >= MegaCost) //Kollar om man kan vinna
    {
        HasWon = true;
    }


    int x = 0; // Där x är den mest produktiva byggnaden jag har råd med.
    for (int i = 0; i < Buildings.Length/2; i++) //Köpa byggnader
    {
        if (Buildings[i, 0] > x && Buildings[i, 1] <= Pickles)
        {
            x = i;
        }
    }
    list.Add(x);
    x = 0;
    Pickles -= Buildings[x, 1];
}
Console.Write(Svar);
int b = Buildings[50, 5];