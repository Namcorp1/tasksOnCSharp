/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

// сортировка элементов по строкам
int[,] SortMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    // копирую матрицу, пока не дошло как сделать это без копирования матрицы
    int[,] res = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++) res[i,j] = matrix[i,j];
    }
    // теперь заводим отдельную переменную для максимального числа 
    // и прогоняем снова матрицу
    int max;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            
            for (int k = j + 1; k < columns; k++)
            {
                if (res[i, k] > res[i, j])
                {
                    max = res[i, k];
                    res[i, k] = res[i, j];
                    res[i, j] = max;
                }
            }
        }
    }
    return res;
}

// вывод результата
void PrintResult(int[,] before, int[,] after)
{
    Console.WriteLine("Исходная матрица:");
    int r = before.GetLength(0);
    int c = before.GetLength(1);
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Console.Write($" {before[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Отсортированная матрица:");
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Console.Write($" {after[i, j]} ");
        }
        Console.WriteLine();
    }
}

// клиентский код
// без реализации выбора метода заполнения матрицы
// данный выбор есть в task_58 в cSharp_hw07
int rows = InputData("кол-во строк");
int columns = InputData("кол-во столбцов");
int lBound = InputData("нижний предел матрицы");
int uBound = InputData("верхний предел матрицы");
int[,] matrix = CreateMatrix(rows, columns);
matrix = FillMatrix(matrix, lBound, uBound);
int[,] result = SortMatrix(matrix);
PrintResult(matrix, result);