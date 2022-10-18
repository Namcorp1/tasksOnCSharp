/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

//приглашение ко вводу
int InputData(string text)
{
    Console.Write($"Введите {text}: ");
    int s = Convert.ToInt32(Console.ReadLine());
    return s;
}

//создание массива со случайными числами
int[] ArrayCreate(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

//нахождение суммы чисел на нечётных позициях
int SumNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2) sum += arr[i];
    return sum;
}

//вывод результата
void PrintResult(int[] arr, int sum)
{
    string output = $"{string.Join(',', arr)} -> {sum}";
    Console.WriteLine(output);
}

//клиентский код
Console.WriteLine("start");
int size = InputData("размер массива");
int lBound = InputData("нижний предел чисел массива");
int uBound = InputData("верхний предел массива");
int[] numbers = ArrayCreate(size, lBound, uBound);
int result = SumNumbers(numbers);
PrintResult(numbers, result);
Console.WriteLine("end");