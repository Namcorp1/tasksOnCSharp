/* Есть число N. Скольно групп M, можно получить при разбиении 
всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.
Например для N = 50, M получается 6
Одно из решений :
    Группа 1: 1 
    Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
    Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
    Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
    Группа 5: 7 16 24 36 40 
    Группа 6: 5 32 48
Ещё одно решение:
    Группа 1: 1 
    Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
    Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
    Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
    Группа 5: 16 24 36 40 
    Группа 6: 32 48 */

// ввод данных
int InputSizeArray()
{
    int num = 0;
    bool check = false;
    while (!check)
    {
        Console.Write("Введите число: ");
        string data = Console.ReadLine();
        check = int.TryParse(data, out num);
    }
    return num;
}

// создание массива
int[] CreateArray(int size) { return new int[size]; }

// наполнение массива
int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }
    return arr;
}

// цикл выведения группы
int CreateGroup(int[] arr, int dif)
{
    int[] group = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == dif) return arr[i];
        else if (arr[i] % dif != 0) return CreateGroup(arr, dif + 1);
    }
    Console.WriteLine(string.Join(',', group));
}

int size = InputSizeArray();
int[] numbers = CreateArray(size);
numbers = FillArray(numbers);
CreateGroup(numbers, 2);