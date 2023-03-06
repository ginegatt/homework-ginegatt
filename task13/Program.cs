// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
int ThirdNumber(int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    return number % 10;
}
Console.WriteLine($"Третья цифра -> {ThirdNumber(number)}");