/* В двумерном массиве n×k заменить 
четные элементы на противоположные */

//ввод кол-ва строк и столбцов
int InputData(string text)
{
    Console.Write($"Введите {text} в массиве: ");
    int data = Convert.ToInt32(Console.ReadLine());
    return data;
}

//создание пустого массива
int[,] CreateArray(int row, int col) { return new int[row, col]; }

//наполнение массива
int[,] FillArray(int[,] empty, int min, int max)
{
    for (int i = 0; i < empty.GetLength(0); i++)
    {
        for (int j = 0; j < empty.GetLength(1); j++)
        {
            empty[i, j] = new Random().Next(min, max + 1);
        }
    }
    return empty;
}

//замена чётных элементов
int[,] Mod2To0(int[,] array)
{
    /* будем копировать входной массив и наполнять теми же значениями, 
    только уже с необходимыми условиями */
    int[,] array2 = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0) array2[i, j] = -array[i, j];
            else array2[i, j] = array[i, j];
        }
    }
    return array2;
}

//вывод результата
void PrintResult(int[,] before, int[,] after)
{
    Console.WriteLine("Было: ");
    for (int i = 0; i < before.GetLength(0); i++)
    {
        for (int j = 0; j < before.GetLength(1); j++)
        {
            Console.Write($" {before[i, j]}");

        }
        Console.WriteLine();
    }
    Console.WriteLine("Стало: ");
    for (int i = 0; i < after.GetLength(0); i++)
    {
        for (int j = 0; j < after.GetLength(1); j++)
        {
            Console.Write($" {after[i, j]}");
        }
        Console.WriteLine();
    }
}

//клиентский код
Console.WriteLine("start");
int rows = InputData("кол-во строк");
int columns = InputData("кол-во столбцов");
int lBound = InputData("нижнюю границу");
int uBound = InputData("верхнюю границу");
int[,] numbers = CreateArray(rows, columns);
numbers = FillArray(numbers, lBound, uBound);
int[,] correctNumbers = Mod2To0(numbers);
PrintResult(numbers, correctNumbers);
Console.WriteLine("end");