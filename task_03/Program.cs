// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// minValue - мин. число для рандома, maxValue - макс. число для рандома

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

int[,] ChangeMatrix(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i += 2) // стр
{
for (int j = 0; j < matr.GetLength(1); j += 2) // столбцы
{
// if (i % 2 == 0 && j % 2 == 0)
// {
matr[i, j] *= matr[i, j];
// matr[i, j] = matr[i, j] * matr[i, j]
// }
}
}
return matr;
}


int[,] array2D = GetMatrix(rows, columns, 0, 10);
PrintMatrix(array2D); // Тут матрицу сохранили для дал. испол.
Console.WriteLine("Результат: ");
PrintMatrix(ChangeMatrix(array2D));


// 2 способ
// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Console.Write("Введите количество строк в массиве: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов в массиве: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// // minValue - мин. число для рандома, maxValue - макс. число для рандома

// int[,] GetMatrix(int m, int n, int minValue, int maxValue)
// {
// int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
// for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
// {
// // i, j, k, m
// for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
// {
// matrix[i, j] = new Random().Next(minValue, maxValue + 1);
// }
// }
// return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++) // строчки
// {
// for (int j = 0; j < matr.GetLength(1); j++) // столбцы
// {
// Console.Write($"{matr[i, j]}\t"); // Литерал, \t = tab
// }
// Console.WriteLine();
// }
// }

// int[,] ChangeMatrix(int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i += 2) // стр
// {
// for (int j = 0; j < matr.GetLength(1); j += 2) // столбцы
// {
// // if (i > 0 && i % 2 == 0 && j > 0 && j % 2 == 0)
// // {
// matr[i, j] *= matr[i, j];
// // matr[i, j] = matr[i, j] * matr[i, j]
// // }
// }
// }
// return matr;
// }


// int[,] array2D = GetMatrix(rows, columns, 0, 10);
// PrintMatrix(array2D); // Тут матрицу сохранили для дал. испол.
// Console.WriteLine("Результат: ");
// PrintMatrix(ChangeMatrix(array2D));