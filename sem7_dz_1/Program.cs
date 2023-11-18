// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размерность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

// Также, задайте метод PrintArray, который выводил бы массив на экран.

// Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы. Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.

// m = 3, n = 4, minLimitRandom = -10, maxLimitRandom = 10


Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// minValue - мин. число для рандома, maxValue - макс. число для рандома

int[,] GetMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
int[,] matrix = new int[m, n]; // [кол-во строк, кол-во столбцов]
for (int i = 0; i < matrix.GetLength(0); i++) // строчки, m = matrix.GetLength(0)
{
// i, j, k, m
for (int j = 0; j < matrix.GetLength(1); j++) // столбцы, n = matrix.GetLength(1)
{
matrix[i, j] = new Random().Next(minLimitRandom, maxLimitRandom + 1);
}
}
return matrix;
}

// void PrintMatrix(int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++) // строчки
// {
// for (int j = 0; j < matr.GetLength(1); j++) // столбцы
// {
// Console.Write($"{matr[i, j]}\t"); // Литерал, \t = tab
// }
Console.WriteLine($"{minLimitRandom:}\t");
// }
// }
// PrintMatrix(array2D); // Тут матрицу сохранили для дал. испол.
// Console.WriteLine("Р