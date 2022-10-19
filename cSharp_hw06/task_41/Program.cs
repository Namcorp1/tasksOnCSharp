/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

//приглашение ко вводу
int[] InputData()
{
    Console.WriteLine("Вводите необходимое кол-во чисел, после введите любую букву на клавиатуре.");
    int[] arr = new int[1];
    int count = 1;
    int number = 0;
    bool check = true; //делаем проверку на ввод числа, чтобы вводить числа пока не введут букву
    string data = "";
    while (check) //цикл проверки ввода данных
    {
        Console.Write($"Введите {count} число: ");
        data = Console.ReadLine();
        check = int.TryParse(data, out number);
        if (check)
        {
            arr[count - 1] = number;
            Array.Resize(ref arr, arr.Length + 1);
            count += 1;
        }
        else break;
    }
    Array.Resize(ref arr, arr.Length - 1); //убираем заключительный элемент, так как мы для него добавили место, но ничего не положили
    return arr;
}

//обработка массива
int CountUpZero(int[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) n++;
    }
    return n;
}

//вывод результата
void PrintResult(int[] arr, int num)
{
    string output = $"{string.Join(',', arr)} -> {num}";
    Console.WriteLine(output);
}

//клиентский код
Console.WriteLine("start");
int[] array = InputData();
int result = CountUpZero(array);
PrintResult(array, result);
Console.WriteLine("end");