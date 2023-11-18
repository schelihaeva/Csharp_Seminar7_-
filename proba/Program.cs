 static Random random = new Random();

 CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom); {
    double[, ] matrix = new double[m, n];

    for (int i = 0; i < m; i++) {
      for (int j = 0; j < n; j++) {
        matrix[i, j] = random.Next(minLimitRandom, maxLimitRandom + 1) + random.NextDouble();
      }
    }

    return matrix;
  }
 void PrintArray(double[, ] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
      for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write($"{matrix[i, j]:f2}\t");
      }
      Console.WriteLine();
    }
  }
