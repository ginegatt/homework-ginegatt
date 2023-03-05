// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number < 100)
{
    Console.WriteLine("Неверное число");
    return;
}
if (Number > 999)
{
    Console.WriteLine("Неверное число");
    return;
}

int secondNumber = Number / 10 % 10;

Console.WriteLine($"Второе число -> {secondNumber}");