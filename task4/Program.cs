Console.WriteLine("Введите первое число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = FirstNumber;
int SecondNumber;
int ThirdNumber;
if (SecondNumber > max){
    SecondNumber = max;
}
Console.WriteLine($"max = {max}");

// я не смог справиться с ошибкой cs0136 и cs0128
