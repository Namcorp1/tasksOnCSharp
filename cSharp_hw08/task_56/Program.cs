/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

// ввод данных
int InputData(string text)
{
    int n = -1;
    bool check = false;
    while (!check)
    {
        Console.Write($"Введите {text}: ");
        string data = Console.ReadLine();
        check = int.TryParse(data, out n);
    }
    return n;
}

// создание пустой матрицы
int[,] CreateMatrix(int row, int column) { return new int[row, column]; }

// наполнение матрицы
int[,] FillMatrix(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

// нахождение суммы элементов строк
int[] SumElementRows(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] sumRows = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sumRows[i] += matrix[i, j];
        }
    }
    return sumRows;
}

// нахождение наименьшей суммы элементов среди строк
(int, int) MinSumRow(int[] sumRows)
{
    int min = sumRows[0];
    int row = 0;
    for (int i = 0; i < sumRows.Length; i++)
    {
        if (sumRows[i] < min)
        {
            min = sumRows[i];
            row = i + 1;
        }
    }
    return (row, min);
}

//вывод результата
void PrintResult(int[,] matrix, int row, int sum)
{
    Console.WriteLine("Исходная матрица:");
    int r = matrix.GetLength(0);
    int c = matrix.GetLength(1);
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    string output = $"{row} - строка с наименьшей суммой элементов ({sum}).";
    Console.WriteLine(output);
}

//клиентский код
int rows = InputData("кол-во строк");
int columns = InputData("кол-во столбцов");
int lBound = InputData("нижний предел матрицы");
int uBound = InputData("верхний предел матрицы");
int[,] matrix = CreateMatrix(rows, columns);
matrix = FillMatrix(matrix, lBound, uBound);
int[] sumRows = SumElementRows(matrix);
//раскомментить следующую строку чтобы посмотреть суммы всех строк
//Console.WriteLine(string.Join(',', sumRows));
(int row, int sum) = MinSumRow(sumRows);
PrintResult(matrix, row, sum);
