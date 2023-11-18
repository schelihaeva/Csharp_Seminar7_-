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


// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// Михаил Меркушов 1 строка , 7 столбец - такого столбца нет
// Михаил Меркушов 0,3 = 2

double[] FindAverageColumns(int[,] matr)
{
    double[] average = new double[matr.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
        }
        average[j] = Math.Round((double)sum / matr.GetLength(0), 2); // 
    }
    return average;
}
double[] res =  FindAverageColumns(array2D);
Console.WriteLine($"{String.Join(", ", res)}");