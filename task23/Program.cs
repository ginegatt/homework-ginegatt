// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine($"Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

void TableCube(int num)
{
    int index = 1;
    int result = 0;
    while (index <= num)
    {
        result = index * index * index;
        Console.WriteLine($"{index}) {result}");
        index++;
    }
}
TableCube(number);
