// Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

using System;

class Program
{
    static void Main()
    {
        int numRowsA = 3; // Количество строк в первой матрице
        int numColsA = 2; // Количество столбцов в первой матрице
        int numRowsB = 2; // Количество строк во второй матрице
        int numColsB = 4; // Количество столбцов во второй матрице

        int[,] matrixA = GenerateRandomMatrix(numRowsA, numColsA);
        int[,] matrixB = GenerateRandomMatrix(numRowsB, numColsB);

        Console.WriteLine("Первая матрица:");
        PrintMatrix(matrixA);

        Console.WriteLine("Вторая матрица:");
        PrintMatrix(matrixB);

        if (numColsA == numRowsB)
        {
            int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

            Console.WriteLine("Результирующая матрица:");
            PrintMatrix(resultMatrix);
        }
        else
        {
            Console.WriteLine("Умножение матриц невозможно из-за несовпадения размеров.");
        }
    }

    static int[,] GenerateRandomMatrix(int numRows, int numCols)
    {
        int[,] matrix = new int[numRows, numCols];
        Random random = new Random();

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                matrix[i, j] = random.Next(1, 11); // Заполняем случайными числами от 1 до 10
            }
        }

        return matrix;
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int numRowsA = matrixA.GetLength(0);
        int numColsA = matrixA.GetLength(1);
        int numRowsB = matrixB.GetLength(0);
        int numColsB = matrixB.GetLength(1);

        int[,] resultMatrix = new int[numRowsA, numColsB];

        for (int i = 0; i < numRowsA; i++)
        {
            for (int j = 0; j < numColsB; j++)
            {
                int sum = 0;
                for (int k = 0; k < numColsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}