// произведение 2-х матриц

//ввод данных по матрицам
int InputData(string text)
{
    Console.Write($"Введите {text}: ");
    int data = Convert.ToInt32(Console.ReadLine());
    return data;
}

// создание пустой матрицы
int[,] CreateArray(int row, int col) { return new int[row, col]; }

//наполнение псевдослучайными числами
int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = new Random().Next(1, 9);
    }
    return arr;
}

//умножение 2 матриц
int[,] MultiPlication(int[,] matrix1, int[,] matrix2, int[,] result)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

//вывод результата
void PrintResult(int[,] matrix1, int[,] matrix2, int[,] result)
{
    Console.WriteLine("Матрица 1:");
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($" {matrix1[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Матрица 2:");
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($" {matrix2[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Результат:");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write($" {result[i, j]} ");
        }
        Console.WriteLine();
    }
}

//клиентский код
int rows1 = InputData("кол-во строк 1ой матрицы");
int columns1 = InputData("кол-во столбцов 1ой матрицы");
int rows2 = InputData("кол-во строк 2ой матрицы");
int columns2 = InputData("кол-во столбцов 2ой матрицы");
if (columns1 == rows2)
{
    int[,] matrix1 = CreateArray(rows1, columns1);
    int[,] matrix2 = CreateArray(rows2, columns2);
    matrix1 = FillArray(matrix1);
    matrix2 = FillArray(matrix2);
    int[,] result = CreateArray(rows1, columns2);
    result = MultiPlication(matrix1, matrix2, result);
    PrintResult(matrix1, matrix2, result);
}
else Console.WriteLine("Матрицы несовместимы для умножения!");