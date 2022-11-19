/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[] InputData()
{
    Console.Write("Введите размеры трёхмерного массива через запятую: ");
    string[] size = new string[3];
    string input = Console.ReadLine();
    size = input.Split(',');
    int[] sizeArray = new int[3];
    int i = 0;
    while (i < size.Length)
    {
        if (!int.TryParse(size[i], out sizeArray[i]))
        {
            Console.Write("Введите размеры трёхмерного массива через запятую: ");
            input = Console.ReadLine();
            size = input.Split(',');
            i = 0;
        }
        else i++;
    }
    return sizeArray;
}

int[] NumbersArray(int[] sizeArray)
{
    int size = 1;
    for (int i = 0; i < sizeArray.Length; i++) { size *= sizeArray[i]; }
    int[] numbers = new int[2];
    numbers[0] = new Random().Next(10, 100);
    while (numbers.Length <= size)
    {
        int num = new Random().Next(10, 100);
        numbers[numbers.Length - 1] = num;
        if (!CheckNumber(numbers, num)) Array.Resize(ref numbers, numbers.Length - 1);
        else Array.Resize(ref numbers, numbers.Length + 1);
    }
    Array.Resize(ref numbers, numbers.Length - 1);
    return numbers;
}

bool CheckNumber(int[] nums, int num)
{
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (num == nums[i]) return false;
    }
    return true;
}

int[,,] AddArray(int[] sizeArray, int[] nums)
{
    int[,,] res = new int[sizeArray[0], sizeArray[1], sizeArray[2]];
    int s = 0;
    for (int i = 0; i < sizeArray[0]; i++)
    {
        for (int j = 0; j < sizeArray[1]; j++)
        {
            for (int k = 0; k < sizeArray[2]; k++)
            {
                res[i, j, k] = nums[k+s];
            }
            s += sizeArray[2];
        }
    }
    return res;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($" {arr[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[] sizeArray = InputData();
int[] numbers = NumbersArray(sizeArray);
int[,,] result = AddArray(sizeArray,numbers);
PrintArray(result);
