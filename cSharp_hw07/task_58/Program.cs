/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

//ввод данных по матрицам
int InputData(string text)
{
    bool check = false;
    int num = 0;
    while (!check)
    {
        Console.Write($"Введите {text}: ");
        string data = Console.ReadLine();
        check = int.TryParse(data, out num);
    }
    return num;
}

// создание пустой матрицы
int[,] CreateArray(int row, int col) { return new int[row, col]; }

//выбор способа наполнения массива
int Choice()
{
    Console.WriteLine("Выберите способ наполнения массива числами:");
    Console.WriteLine("0 - автоматически.");
    Console.WriteLine("1 - вручную.");
    bool check = false;
    int num = -1;
    while (!(check && num < 2 && num > -1))
    {
        Console.Write($"Способ наплонения массива: ");
        string data = Console.ReadLine();
        check = int.TryParse(data, out num);
    }
    return num;
}

//наполнение псевдослучайными числами
int[,] FillArrayAuto(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) arr[i, j] = new Random().Next(min, max + 1);
    }
    return arr;
}

//ручное наполнение массива
int[,] FillArrayManual(int[,] arr, string numArr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            bool check = false;
            while (!check)
            {
                Console.Write($"Введите число для позиции ({i}, {j}) {numArr} матрицы: ");
                string data = Console.ReadLine();
                check = int.TryParse(data, out arr[i, j]);
            }
        }
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
    //осздаем шаблоны матриц
    int[,] matrix1 = CreateArray(rows1, columns1);
    int[,] matrix2 = CreateArray(rows2, columns2);
    //выбираем метод наполнения
    int choiceFill = Choice();
    if (choiceFill == 0)
    {
        int lBound = InputData("нижний предел матриц");
        int uBound = InputData("верхний предел матриц");
        matrix1 = FillArrayAuto(matrix1, lBound, uBound);
        matrix2 = FillArrayAuto(matrix2, lBound, uBound);
    }
    else if (choiceFill == 1)
    {
        matrix1 = FillArrayManual(matrix1, "1");
        matrix2 = FillArrayManual(matrix2, "2");
    }
    int[,] result = CreateArray(rows1, columns2);
    result = MultiPlication(matrix1, matrix2, result);
    PrintResult(matrix1, matrix2, result);
}
else Console.WriteLine("Матрицы несовместимы для умножения!");