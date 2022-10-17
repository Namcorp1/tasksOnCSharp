
int Input(string text)
{
    Console.Write($"Введите кол-во {text}: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int[,] AddMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

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
        avNum[j] = Math.Round(sum / numbers.GetLength(0),1);
    }
    return avNum;
}


// клиентский код
int rows = Input("строк");
int columns = Input("столбцов");
int[,] matrix = AddMatrix(rows, columns);
double[] result = Result(matrix);
Console.WriteLine("---------------------------------");
Console.WriteLine(string.Join(' ',result));
