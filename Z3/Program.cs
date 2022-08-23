
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int numberDay = Convert.ToInt32(Console.ReadLine());

if(numberDay < 1 || numberDay > 7)
{
    Console.WriteLine("Ошибка");
    Environment.Exit(0);
}
if (numberDay < 6)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Выходной");
}

// Второй вариант c подписанными днями недели:
// Console.WriteLine("Введите число");
// int numberDay = Convert.ToInt32(Console.ReadLine());

// if(numberDay < 1 || numberDay > 7)
// {
//     Console.WriteLine("Ошибка");
// }
// if(numberDay == 1)
// {
//     Console.WriteLine("Понедельник - рабочий день");
// }

// if(numberDay == 2)
// {
//     Console.WriteLine("Вторник - рабочий день");
// }

// if(numberDay == 3)
// {
//     Console.WriteLine("Среда - рабочий день");
// }

// if(numberDay == 4)
// {
//     Console.WriteLine("Четверг - рабочий день");
// }

// if(numberDay == 5)
// {
//     Console.WriteLine("Пятница - короткий день");
// }

// if(numberDay == 6)
// {
//     Console.WriteLine("Суббота - выходной");
// }

// if(numberDay == 7)
// {
//     Console.WriteLine("Воскресенье - выходной");
// }