// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 6)
{
    Console.WriteLine("Будний день");
    return;
}
if (number > 6 && number < 8)
{
    Console.WriteLine("Выходной день");
    return;
}
if (number > 7)
{
    Console.WriteLine("Введён неверный день");
    return;
}

