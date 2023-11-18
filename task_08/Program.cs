// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// // // Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// // // minValue - мин. число для рандома, maxValue - макс. число для рандома  

if (rows != columns) // Прямоугольная матрица
{
    Console.WriteLine("Такую матрицу повернуть нельзя");
    return; //остановили всю программу
}


int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
    {
        // i, j, k, m
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}\t"); // Литерал, \t = tab
        }
        Console.WriteLine();
    }
}
int[,] ChangeMatrix(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)]; // result - копия матрицы
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            result[j, i] = matrix[i, j];
        }
    }
    return result;
}

int[,] array2D = GetMatrix(rows, columns, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
PrintMatrix(ChangeMatrix(array2D));