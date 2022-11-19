//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<1000 && number>99)
{
    int number2 = number / 10;
    int secondDigit = number2 % 10;
    Console.WriteLine($"Вторая цифра: {secondDigit}");
}

else
{
    Console.WriteLine("Введенное число не является трехзначным.");
}