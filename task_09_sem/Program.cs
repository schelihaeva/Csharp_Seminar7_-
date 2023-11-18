//Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int rows = 3;
int columns = 3;

int[,] matrix = new int[rows, columns]; // 3 стр, 3 столбца
int min = int.MaxValue;

int indexMinRows = 0; // Пусть мин элемент лежит на позиции 0 стр, 0 стл
int indexMinColumns = 0; // Пусть мин элемент лежит на позиции 0 стр, 0 стл
for (int i = 0; i < matrix.GetLength(0); i++) // строчки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write($"{matrix[i, j]}\t");
        if (min > matrix[i, j]) // 5000 > 1000, min = 1000
        {
            min = matrix[i, j];
            indexMinRows = i;
            indexMinColumns = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"min = {min}, [{indexMinRows}, {indexMinColumns}]");


for (int i = 0; i < matrix.GetLength(0); i++) // строчки
{
    // indexMinRows  = 2, i = 0,1,2,3
    // indexMinRows != i: все i, кроме indexMinRows  = 2: 0,1,3
    if (indexMinRows != i) // Печатаю все строчки, кроме строчки с мин. эл.
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            if(indexMinColumns != j) //Печатаю все столбцы, кроме столбца с мин. эл.
            {
                Console.Write($"{matrix[i, j]}\t");
            } 
        }
        Console.WriteLine();
    }
}