//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 6)
{
    Console.WriteLine("День является рабочим");
}

else if (number > 5 && number < 8)
{
    Console.WriteLine("День является выходным");
}

else
{
    Console.WriteLine("Такого дня недели не существует");
}