// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadInt(string text) //примаем строку ко вводу
{
    Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void PrintNumbers(int number) // вводим цикл

{
    if (number <= 0) return;
    PrintNumbers(number-1);
    Console.Write(number + " ");
}


PrintNumbers(ReadInt("Введите число:"));