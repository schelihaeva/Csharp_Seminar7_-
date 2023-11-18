// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
 int ReadInt(string text)
{
    Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Pow(int number, int power)
{
    if (power <= 1) return number;
    return number*Pow(number,power-1);
}


int A = ReadInt("Введите число А:");
int B = ReadInt("Введите число B (степень):");
Console.WriteLine(Pow(A,B));