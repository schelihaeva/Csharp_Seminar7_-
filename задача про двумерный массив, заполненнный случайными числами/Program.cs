// Задайте двумерный массив размером m * n ,заполненный случайными целыми числами
//m=3(кол-во строк) n=3 (кол-во столбцов)
//1 4 8 19
//5-2 33-2
//77 3 81

// System.Console.WriteLine("введите количество строк в массиве: ");
// int rows = Convert.ToInt32(Console.ReadLine());  // конвертируем в целое число               // rows - строки

// System.Console.WriteLine("введите количество солбцов в массиве: ");
// int colums = Convert.ToInt32(Console.ReadLine());    // colums - столбцы

// // надо создать сначала метод, который массив заполнит, а потом создать массив, кторый его заполнит
// // int[] - одномерный массив(x)
// // int[,] - двумерный массив (x,y)
// // int[,,] - трехмерный массив (x,y,z)
// // матрица-таблица, размером m на n
// // minValue-минимальное значение в коде.  для рандома maxValue-максимальное значение в коде
// int[,] GetMatrix(int m, int n, int minValue, int maxValue)                // можно указать Get2DArray-получение двухмерного массива, Get3DArray - получение трехмерного массива, GetArray -получение одномерного массива
// {
//     int[,] matrix = new int[m, n]; //[кол-во строк, кол-во столбцов]
//     for (int i = 0; i < matrix.GetLenght(0); i++)// прохходим по всем строчкам Getlenght(0) = m - длинна массива, кол-вос строк(0), GetLenght(1)=n - кол-во столбцов(1)
//     {
//         for (int j = 0; j < matrix.GetLenght(1); j++) // cтолбцы, вводим переменную j
//         {
//             matrix[i,j]= new Random().Next(minValue, maxValue + 1); // находим переменную массива указываем в каком диапазоне работаем minValue maxValue+1, чтобы найти макс значение для этого +1
//         }
//     }
//     return matrix; //возвращаем матрицу
// }
// int[,] array2D = GetMatrix(rows, colums, 0, 10); // создаем матрицу, вводим массив
// PrintMatrix(array2D); //печатаем матрицу array2D

// void PrintMatrix(int[,] matr) //void-напечатает матрицу, процедура, котороая не возвращает никакого значения,только выводит
// {
//     for (int i = 0; i < matr.GetLenght(0); i++)// цикл проходит по строчкам
//     {
        
//     for (int j = 0; j < matrixGetLenght(1); j++) // цикл проходит по столбцам

//     {
//           Console.Write($"{matr[i,j]}\t");        //печатаем в одну строчку Console.WriteLine -напечатается эелемент на новой строке, а не в одну строку // \t = tab-четыре пробела между значениями, литерал
//     }
//     Console.WriteLine();   //переход на другу строку
//     }
// }

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