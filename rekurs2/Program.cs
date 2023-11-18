// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void PrintNumbers(int startNumber, int stopNumber)
{
    if (startNumber > stopNumber) return;
    Console.Write(startNumber + " ");
    PrintNumbers(startNumber + 1, stopNumber);
}


int N = ReadInt("Введите число N:");
int M = ReadInt("Введите число M:");

if (N>M) 
{
    Console.WriteLine("Значение N больше значения M.");
    return;
}
 
PrintNumbers(N, M);