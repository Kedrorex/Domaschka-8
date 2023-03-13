// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] PowMatrix(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
    if (matrA.GetLength(1) == matrB.GetLength(0))
    {
        // c[ij] = ai1 · b1j + ai2 · b2j + ... + a[in] · b[nj]
        for (int i = 0; i < matrC.GetLength(0); i++)
        {
            for (int j = 0; j < matrC.GetLength(1); j++)
            {
                for (int n = 0; n < matrC.GetLength(1); n++)
                {
                    matrC[i, j] += matrA[i, n] * matrB[n, j];
                }

            }
        }
    }
    else
    {
        System.Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В. ");
    }
    return matrC;
}

System.Console.Write("Введите кол-во строк Maтрицы А: ");
int rowA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов Maтрицы А: ");
int columnA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

System.Console.Write("Введите кол-во строк Maтрицы B: ");
int rowB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов Maтрицы B: ");
int columnB = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = FillMatrixWithRandom(rowA, columnA);
int[,] matrixB = FillMatrixWithRandom(rowB, columnB);

PrintMatrix(matrixA);
Console.WriteLine();

PrintMatrix(matrixB);
Console.WriteLine();

int [,] matrixC = PowMatrix(matrixA, matrixB);
PrintMatrix(matrixC);