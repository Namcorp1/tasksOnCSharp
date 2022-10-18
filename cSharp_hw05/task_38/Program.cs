/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

//приглашение ко вводу
double InputData(string text)
{
    Console.Write($"Введите {text}: ");
    double s = Convert.ToDouble(Console.ReadLine());
    return s;
}

//создание массива со случайными числами
double[] ArrayCreate(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return array;
}

//нахождение максимального и минимального элементов массива
(double, double) MinMaxNumber(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    return (min, max);
}

//нахождение разности между мин и макс элементами
double Result(double min, double max) { return max - min; }

//вывод результата
void PrintResult(double[] arr, double result)
{
    string output = $"{string.Join(';',arr)} -> {result}";
    Console.WriteLine(output);
}

//клиентский код
Console.WriteLine("start");
int size = Convert.ToInt32(InputData("размер массива"));
double[] numbers = ArrayCreate(size);
(double min, double max) = MinMaxNumber(numbers);
double result = Result(min, max);
PrintResult(numbers, result);
Console.WriteLine("end");