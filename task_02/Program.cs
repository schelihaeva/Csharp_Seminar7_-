// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// minValue - мин. число для рандома, maxValue - макс. число для рандома
// формула m+n=Amn (номер строки+номер столбца)
int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
{
// i, j, k, m
for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
{
matrix[i, j] = i+j; //Mil = i+j
}
}
return matrix;
}

int[,] array2D = GetMatrix(rows, columns, 0, 10);
PrintMatrix(array2D);
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