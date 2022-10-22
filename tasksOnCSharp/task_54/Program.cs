// 54. В матрице чисел найти сумму элементов главной диагонали

//ввод строк и столбцов
(int, int, int) InputData()
{
    Console.WriteLine("Так как главная диагональ может быть только в квадратной матрице,");
    Console.WriteLine("то введите число, которое будет кол-ом строк и столбцов.");
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите нижний предел массива: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхний предел массива: ");
    int max = Convert.ToInt32(Console.ReadLine());
    return (num, min, max);
}

//создание пустой матрицы
int[,] CreateArray(int data) { return new int[data, data]; }

//заполнение матрицы
int[,] FillArray(int[,] emptyArray, int min, int max)
{
    int count = emptyArray.GetLength(0);
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count; j++)
        {
            emptyArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return emptyArray;
}

//нахождение сумм диагоналей
(int, int) DiagonalSum(int[,] array)
{
    int sumD1 = 0;
    int sumD2 = 0;
    int count = array.GetLength(0);
    for (int i = 0; i < count; i++) sumD1 += array[i, i];
    for (int i = 0; i < count; i++) sumD2 += array[i, count - 1 - i];
    return (sumD1, sumD2);
}

//вывод результата
void PrintResult(int[,] array, int sumD1, int sumD2)
{
    int count = array.GetLength(0);
    Console.WriteLine("Массив был вот такой:");
    for (int i = 0; i < count; i++)
    {
        for (int j = 0; j < count; j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    string output1 = $"Сумма диагонали сверху слева вниз вправо равна {sumD1}";
    string output2 = $"Сумма диагонали снизу слева вверх вправо равна {sumD2}";
    Console.WriteLine(output1);
    Console.WriteLine(output2);
}

//клиентский код
(int count, int lBound, int uBound) = InputData();
int[,] array = CreateArray(count);
array = FillArray(array, lBound, uBound);
(int sumD1, int sumD2) = DiagonalSum(array);
PrintResult(array, sumD1, sumD2);