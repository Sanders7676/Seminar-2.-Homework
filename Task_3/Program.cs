﻿Random rand = new Random();

int number = rand.Next(1, 8);

if (number < 6)
{
    Console.Write($"{number}-й день недели - это рабочий день.");
}
else
{
    Console.Write($"{number}-й день недели - это выходной день.");
}