// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

//ввод данных
int InputData(string text)
{
    Console.Write($"Введите {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//создание пустого массива
int[,] CreateArray(int row, int col) { return new int[row, col]; }

//заполнение массива
int[,] FillArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

//нахождение строки с минимальной суммой элементов
(int, int) MinSumRow(int[,] array)
{
    int row = -1;
    int sum = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum) minSum = sum; row = i;
    }
    return (row, minSum);
}

//вывод результата
void PrintResult(int[,] arr, int row, int sum)
{
    Console.WriteLine("Массив был вот такой:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    string output = $"Минимальная сумма элементов в {row} строке, она равна {sum}";
    Console.WriteLine(output);
}

//клиентский код
Console.WriteLine("start");
int rows = InputData("кол-во строк");
int columns = InputData("кол-во столбоцов");
int lBound = InputData("нижний предел массива");
int uBound = InputData("верхний предел массива");
int[,] numbers = CreateArray(rows, columns);
numbers = FillArray(numbers, lBound, uBound);
(int rowMinSum, int minSum) = MinSumRow(numbers);
PrintResult(numbers, rowMinSum, minSum);
Console.WriteLine("end");