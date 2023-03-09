// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine());
int rem, sum = 0;
int temp = number;
while (number > 0)
{

    rem = number % 10;
    sum = (sum * 10) + rem;
    number = number / 10;
}
if (temp == sum)
{
    Console.WriteLine($"Число {temp} является полиндромом");
}
else
{
    Console.WriteLine($"Число {temp} не является полиндромом");
}