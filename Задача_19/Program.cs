// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();

Console.WriteLine("Введите пятезначное число: ");
int numb = int.Parse(Console.ReadLine()!);
int numb1 = 0;
int numb2 = 0;
int numb3 = 0;
int numb4 = 0;

if (numb >= 10000 || numb < 10000)
{
    Console.WriteLine("Введите число от 10000 до 99999: ");
}

else if (numb <= 99999)
{
    numb1 = numb / 10000;
    numb2 = numb % 10;
    numb3 = numb / 1000 % 10;
    numb4 = numb % 100 / 10;
    
if (numb1 == numb2 && numb3 == numb4)
    {
        Console.Write("Да");
    }

else
    {
        Console.Write("Нет");
    }
} 