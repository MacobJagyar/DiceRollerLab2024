using System;
using System.Xml;

int diceChoice = 0;

while (true)
{
    Console.Write("How many sides should each dice have? ");
    if (int.TryParse(Console.ReadLine(), out diceChoice))
    {
        int diceOne = GenRandom(diceChoice);
        int diceTwo = GenRandom(diceChoice);


        Console.WriteLine($"\nYou rolled: {diceOne} and {diceTwo}");

        if (diceChoice == 6)
        {
            Console.WriteLine(DiceCombos(diceOne, diceTwo));
            Console.WriteLine(DiceTotal(diceOne, diceTwo));
        }

        Console.Write("\nWould you like to try again? (y/n) ");
        string loopChoice = Console.ReadLine().ToLower();

        if (loopChoice == "y")
        {
            Console.WriteLine("\nRestarting...");
            Thread.Sleep(1500);
            Console.Clear();
        }
        else if (loopChoice == "n")
        {
            Console.WriteLine("\nGoodbye!");
            break;
        }
        else
        {
            Console.WriteLine("\nThat wasnt y or n! Restarting again anyways...");
            Thread.Sleep(1500);
            Console.Clear();
        }
    }
    else
    {
        Console.WriteLine("\nNot valid, try again");
        Thread.Sleep(1500);
        Console.Clear();
    }
}

static int GenRandom(int x)
{
    Random random = new Random();

    int randNum = random.Next(1, x + 1);

    return randNum;
}

static string DiceCombos(int x, int y)
{
    if (x == 1 && y == 1)
    {
        return "Snake Eyes";
    }
    else if (x == 1 && y == 2 || y == 1 && x == 2)
    {
        return "Ace Deuce";
    }
    else if (x == 6 && y == 6)
    {
        return "Box Car";
    }
    else
    {
        return "";
    }
}

static string DiceTotal (int x, int y)
{
    int diceSum = x + y;

    if (diceSum == 7 || diceSum == 11)
    {
        return "Win";
    }
    else if (diceSum == 2 || diceSum == 3 || diceSum == 12)
    {
        return "Craps";
    }
    else 
    { 
        return ""; 
    }
}
