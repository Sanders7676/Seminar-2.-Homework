// Задача № 1
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Random rand = new Random();

int number = rand.Next(100, 1000);

Console.WriteLine($"Наше число - {number}.");

int div = (number / 10) % 10;

Console.WriteLine($"Вторая цифра в этом числе - {div}.");