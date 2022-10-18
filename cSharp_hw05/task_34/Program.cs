/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//приглашение ко вводу
int InputSize()
{
    Console.Write("Введите размер массива: ");
    int s = Convert.ToInt32(Console.ReadLine());
    return s;
}

//создание массива с случайными трёхзначными числами
int[] ArrayCreate(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

//подсчёт чётных чисел в массиве
int CountMod2To0(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result += 1;
    }
    return result;
}

//вывод результата
void PrintResult(int[] arr, int result)
{
    string output = $"{string.Join(',', arr)} -> {result}";
    Console.WriteLine(output);
}

//клиентский код
Console.WriteLine("start");
int size = InputSize();
int[] numbers = ArrayCreate(size);
int result = CountMod2To0(numbers);
PrintResult(numbers, result);
Console.WriteLine("end");