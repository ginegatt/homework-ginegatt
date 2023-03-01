Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = FirstNumber;
int SecondNumber;
int ThirdNumber;
if (SecondNumber > max)
{
    SecondNumber = max;
}

if (ThirdNumber > max)
{
    ThirdNumber = max;
}
Console.WriteLine("Наибольшее число = " + max);
 break;

// я не смог справиться с ошибками cs0139, cs0136 и cs0128