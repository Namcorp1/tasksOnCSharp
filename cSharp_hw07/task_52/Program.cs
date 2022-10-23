/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

// ввод данных
int InputData(string text)
{
    bool check = false;
    int n = 0;
    while (!check)
    {
        Console.Write($"Введите {text}: ");
        string data = Console.ReadLine();
        check = int.TryParse(data, out n);
    }
    return n;
}
// создание пустой матрицы
int[,] CreateMatrix(int rows, int columns) { return new int[rows, columns]; }
// наполнение матрицы
int[,] FillMatrix(int[,] matrix, int min, int max)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}
// нахождение среднего арифметического по столбцам
double[] Result(int[,] numbers)
{
    double[] avNum = new double[numbers.GetLength(1)];
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sum += numbers[i, j];
        }
        avNum[j] = Math.Round(sum / numbers.GetLength(0), 1);
    }
    return avNum;
}
//вывод результата
void PrintResult(double[] res)
{
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое по столбцам:");
    Console.WriteLine(string.Join(' ', res));
}

// клиентский код
int rows = InputData("кол-во строк");
int columns = InputData("кол-во столбцов");
int lBound = InputData("нижний предел массива");
int uBound = InputData("врехний предел массива");
int[,] matrix = CreateMatrix(rows, columns);
matrix = FillMatrix(matrix, lBound, uBound);
double[] result = Result(matrix);
PrintResult(result);

