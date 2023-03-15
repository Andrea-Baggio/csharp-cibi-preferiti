using System;

string[] foods = { "pizza", "cioccolata", "sushi", "hamburger", "pollo", "gelato", "sabbia" };

int arrLen = foods.Length;

for (int i = 0; i < arrLen; i++)
{
    Console.WriteLine(foods[i]);
}

for (int i = 0; i < arrLen; i++)
{
    if (i == 0)
    {
        Console.WriteLine(foods[i] + ": primo");
    }
    else if (i == arrLen / 2)
    {
        Console.WriteLine(foods[i] + ": medio");
    }
    else if (i == arrLen - 1)
    {
        Console.WriteLine(foods[i] + ": ultimo");
    }
}


Console.WriteLine("La classica comprende " + arrLen + " elementi");