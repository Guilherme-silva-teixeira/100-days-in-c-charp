int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

foreach (int i in sophiaScores)
{
    if (i > 75)
    {
        Console.WriteLine(i+" é maior que 75");
    }
}

foreach (int i in sophiaScores)
{
    if (i > 97 && i < 100)
    {
        Console.WriteLine("A+");
    }
    else if (i > 95 && i < 97)
    {
        Console.WriteLine("A");
    }
    else if (i > 93 && i < 95)
    {
        Console.WriteLine("A-");
    }
    else if (i > 89 && i < 93)
    {
        Console.WriteLine("B+");
    }
    else if (i > 89)
}
