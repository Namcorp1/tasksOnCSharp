/* Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

//ввод данных
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

//создание пустого массива
int[,] CreateArray(int row, int col) { return new int[row, col]; }

//наполнение массива
int[,] FillArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}

//нахождение позиции нужного элемента
(int, int) FindPosition(int[,] arr, int num)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int findRow = -1;
    int findCol = -1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (arr[i, j] == num)
            {
                findRow = i;
                findCol = j;
                break;
            }
        }
        if (findRow != -1) break;
    }
    return (findRow, findCol);
}

//проверка на наличие числа в массиве
bool CheckNumber(int[,] arr, int num)
{
    bool check = false;
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (arr[i, j] == num)
            {
                check = true;
                break;
            }
        }
    }
    return check;
}

//вывод массива
void PrintArray(int[,] arr)
{
    Console.WriteLine("Массив был такой:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//вывод результата
void PrintResult(int num, int row, int col)
{
    string output = $"{num} -> ({row}, {col}).";
    Console.WriteLine(output);
}

//клиентский код
/* Чтобы проверить код на примере из образца,
то нужно раскомментить строку 116
и закомментить строки 109-112, 114-115.*/
Console.WriteLine("start");
int rows = InputData("кол-во строк");
int columns = InputData("кол-во столбцов");
int lBound = InputData("нижний предел массива");
int uBound = InputData("верхний предел массива");
int findNum = InputData("искомое число");
int[,] matrix = CreateArray(rows, columns);
matrix = FillArray(matrix, lBound, uBound);
//int[,] matrix = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintArray(matrix);
if (CheckNumber(matrix, findNum))
{
    (int resRow, int resCol) = FindPosition(matrix, findNum);
    PrintResult(findNum, resRow, resCol);
}
else Console.WriteLine($"{findNum} -> такого числа нет в массиве");
Console.WriteLine("end");