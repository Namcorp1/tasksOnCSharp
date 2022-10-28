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

// создание групп чисел
// int[] CreateGroup(int[] arr, int[] group, int index, int dif)
// {
//     // если мы прогнали массив при одном делителе
//     if (index > arr.Length - 1)
//     {
//         // создаем следующую группу, обнуляем индекс и увеличиваем делитель
//         index = 0;
//         group = new int[arr.Length];
//         return CreateGroup(arr, group, index, dif + 1);
//     }
//     else if (dif > arr.Length)
//     {
//         //если все делители кончились то возвращаем группу чисел
//         return group;
//     }
//     // если не делится без остатка
//     else if (arr[index] % dif != 0)
//     {
//         // то закидываем в новую группу и запускаем
//         group[index] = arr[index];
//         return CreateGroup(arr, group, index + 1, dif);
//     }
//     return CreateGroup(arr, group, index + 1, dif);
// }

int size = InputSizeArray();
int[] numbers = CreateArray(size);
numbers = FillArray(numbers);
int[] res = CreateArray(size);
//res = CreateGroup(numbers, res, 0, 1);
int[] difArray = new int[1];
int n = 0;
int index = 0;
difArray[n] = numbers[index];
index++;
while (index < numbers.Length)
{
    while (n <= difArray.Length)
    {
        if (numbers[index] % difArray[n] == 0)
        {
            if (index < numbers.Length) index++;
        }
        else
        {
            Array.Resize(ref difArray, difArray.Length + 1);
            n++;
            difArray[n] = numbers[index];
        }
        
    }
}
Console.WriteLine(string.Join(',', numbers));
Console.WriteLine(string.Join(',', difArray));