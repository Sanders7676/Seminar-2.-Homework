// Задача № 2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Число введено неверно");
    return;
}

if (number >= 0)
{
    if (number < 100)
    {
        Console.WriteLine("В этом числе нет третьего знака!");
    }
    else
    {
        int discharge = 10;

        if (number >= 1000)
        {
            while ((number / discharge) >= 1000)
            {
                discharge = discharge * 10;
            }

            int result = (number / discharge) % 10;

            Console.WriteLine($"Третья цифра в данном числе это {result}");
        }
        else
        {
            int result = number % 10;

            Console.WriteLine($"Третья цифра в данном числе это {result}");
        }
    }
}
else
{
    Console.WriteLine("Это число меньше нуля.");

}