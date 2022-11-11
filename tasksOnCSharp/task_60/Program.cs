/*
60. Составить частотный словарь элементов двумерного массива
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
Пример: 
Есть набор данных { 1, 9, 9, 0, 2, 8, 0, 9 }
частотный массив может быть представлен так:
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/

//ввод данных
int InputData(string text)
{
    bool check = false;
    int number = 0;
    while (!check)
    {
        Console.Write($"Введите {text}: ");
        string data = Console.ReadLine();
        check = int.TryParse(data, out number);
    }
    return number;
}

//создание массива
int[] CreateArray(int size) { return new int[size]; }

//наполнение массива
int[] FillArray(int[] arr, int lBound, int uBound)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(lBound, uBound + 1);
    }
    return arr;
}

//нахождение всех уникальных символов
int[] UniqueElements(int[] arr)
{
    int[] unique = new int[1];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < unique.Length; j++)
        {
            if (arr[i] != unique[j])
            {
                unique[unique.Length - 1] = arr[i];
            }
        }
    }
    Array.Resize(ref unique, unique.Length - 1);
    return unique;
}

int count = InputData("размер массива");
int min = InputData("нижний предел массива");
int max = InputData("верхний предел массива");
int[] array = CreateArray(count);
array = FillArray(array, min, max);
Console.WriteLine(string.Join(',',array));
int[] res = UniqueElements(array);
Console.WriteLine(string.Join(',',res));
