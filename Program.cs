using System;

string[] foods = { "pizza", "cioccolata", "sushi", "hamburger", "gatti", "pollo", "gelato", "sabbia" };

int arrLen = foods.Length;
int midElements = arrLen / 2;

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
    else if (i == arrLen - 1)
    {
        Console.WriteLine(foods[i] + ": ultimo");
    }
    else if (i == arrLen / 2)
    {
        Console.WriteLine(foods[i] + ": medio");
    }
}


if (arrLen % 2 == 0)
{
    int firstMid = midElements - 1;
    int secondMid = midElements;

    Console.WriteLine(firstMid + ": medio");
    Console.WriteLine(secondMid + ": medio");
}


Console.WriteLine("La classifica comprende " + arrLen + " elementi");