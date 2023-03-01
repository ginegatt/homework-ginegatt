// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = FirstNumber;
if (SecondNumber > max)
{
    SecondNumber = max;
}

if (ThirdNumber > max)
{
    ThirdNumber = max;
}
Console.WriteLine("Наибольшее число = " + max);

// я не смог справиться с ошибками cs0139, cs0136 и cs0128