// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbersToN(int n)
{
    if (n == 1)
    {
       return n.ToString(); 
    }
    return( n + ", " + NumbersToN(n-1));
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (Convert.ToInt32(Console.ReadLine()));
}

int n =EnterData("Введите значение N: ");
string numbersToN = NumbersToN(n);
Console.WriteLine(numbersToN);
