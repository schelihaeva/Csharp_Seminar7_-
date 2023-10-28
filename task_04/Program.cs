double[,] GetDoubleMatrix(int rows, int columns)
{
double[,] matrix = new double[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
{
for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
{
matrix[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2); // 0 - 1000
}
}
return matrix;
}
void PrintDoubleMatrix(double[,] matr)
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
double[,] array2D = GetDoubleMatrix(rows, columns);
PrintDoubleMatrix(array2D); // Тут матрицу сохранили для дал. испол.