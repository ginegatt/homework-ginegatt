// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int a = 0; a < numbers.Length; a += 2)
    sum = sum + numbers[a];

Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int b = 0; b < numbers.Length; b++)
    {
        numbers[b] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int b = 0; b < numbers.Length; b++)
    {
        Console.Write(numbers[b] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}