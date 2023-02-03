// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 100)
{
    while (number > 1000)
    {
        number /= 10;
    }

    int result = number % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третей цифры нет");
}
