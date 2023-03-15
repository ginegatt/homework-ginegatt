// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int lenArray = ReadInt("Введите длинну массива: ");

// int[] randomArray = new int[lenArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }
 Console.WriteLine("Введите любое число (A):");
            enterNumber = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[enterNumber];

            for (int i = 0; i < enterNumber; i++)
            {
                array[i] = new Random().Next(enterNumber+1);
                Console.Write(array[i] + "; ");
            }
            Console.WriteLine();