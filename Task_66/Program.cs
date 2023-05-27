// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersMToN(int m, int n)
{
    if (m == n)
    {
       return m; 
    }
    return( m + SumNumbersMToN(m + 1 ,n));
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (Convert.ToInt32(Console.ReadLine()));
}

int m =EnterData("Введите значение M: ");
int n =EnterData("Введите значение N: ");
int sumNumbersMToN = SumNumbersMToN(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {sumNumbersMToN}");