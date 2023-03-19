// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int arrayLen = 8;

int[] array = new int[arrayLen];

for (int i = 0; i < arrayLen; i++)
{
    array[i] = new Random().Next(arrayLen + 1);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();