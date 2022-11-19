//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000 || number < -99 && number > -1000)
{
    if (number > 0)
    {
        int thirdDigit = number % 10;
        Console.WriteLine($"Третья цифра {thirdDigit}");
    }

    else if (number<0)
    {
        int thirdDigit = - number % 10;
        Console.WriteLine($"Третья цифра {thirdDigit}");
    }
}

while (number > 999 || number < -999)
{
    number = number/10;
    if (number > 0 && number < 1000) 
    {
        int thirdDigit = number % 10;
        Console.WriteLine($"Третья цифра {thirdDigit}");
    }

    else if (number > -1000 && number < 0)
    {
        int thirdDigit = - number % 10;
        Console.WriteLine($"Третья цифра {thirdDigit}");
    }
}

if (number < 100 && number > -100)
{
    Console.WriteLine("Третьей цифры нет");
}