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
// находим минимальный элемент массива 
int MinElement(int[] numbers)
{
    int min = numbers[0];
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = i + 1; j < numbers.Length; j++)
        {

            if (numbers[j] < min)
            {
                min = numbers[j];
            }
        }
    }
    return min;
}
// прогоняем этот элемент через весь массив 
// с добавлением того, что не делиться без остатка
int[] DiffArray(int[] arr, int[] group, int min)
{
    group[group.Length - 1] = min;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == min) arr[i] = 0;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < group.Length; j++)
        {
            if (arr[i] % group[j] != 0)
            {
                Array.Resize(ref group, group.Length + 1);
                group[group.Length - 1] = arr[i];
                if(!(CheckDif(group,arr[i])))
                {
                    group[group.Length - 1] = 0;
                    Array.Resize(ref group, group.Length - 1);
                }
            }
        }
    }
    return group;
}

// проверка на делимость числа
bool CheckDif(int[] nums, int num)
{
    bool[] check = new bool[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % num == 0) check[i] = true;
        else check[i] = false;
    }
    for (int i = 0; i < check.Length; i++)
    {
        if (check[i]) return false;
    }
    return true;
}

int size = InputSizeArray();
int[] numbers = CreateArray(size);
numbers = FillArray(numbers);
int min = MinElement(numbers);
int[] group = new int[1];
group = DiffArray(numbers, group, min);
Console.WriteLine(string.Join(',', numbers));
min = 2;
int[] group2 = new int[1];
group2 = DiffArray(numbers, group2, min);

Console.WriteLine(string.Join(',', group));
Console.WriteLine(string.Join(',', group2));
Console.WriteLine(string.Join(',', numbers));
Console.WriteLine(min);

// начинаем заполнять массив с делителями

