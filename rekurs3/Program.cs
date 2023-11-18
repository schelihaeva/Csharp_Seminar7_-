// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int SumDigitsInNumber(int number)
{
    if(number == 0) return 0;
    return number % 10 + SumDigitsInNumber(number/10);
}

int N = ReadInt("Введите число N:");
Console.WriteLine(SumDigitsInNumber(N));