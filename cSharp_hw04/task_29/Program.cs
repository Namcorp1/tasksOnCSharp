/*
Задача 29: Напишите метод, который задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

Не совсем понял, что именно нужно, поэтому сделаем метод,
в котором мы можем задать длину массива и наполнить её числами
и далее нам программа выведет наш массив
*/

// приглашение ко вводу размера массива
int InputData(string text)
{
    Console.Write($"Введите {text}: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
// набор массива
int[] AddArray(int size)
{
    int count = 0;
    int number = 0;
    int[] array = new int[size];
    //добавим проверку на ввод строковых данных
    bool flag = false;
    // делаем цикл пока не заполним массив до нужного размера и чтобы не было строковых данных
    while (!(flag && count > size - 1))
    {
        Console.Write($"{count + 1} элемент массива = ");
        string data = Console.ReadLine();
        if (flag = int.TryParse(data, out number)) // проверяем переводятся ли введеные данные в число
        {
            array[count] = number;
            count += 1;
        }

    }
    return array;
}
// вывод результата
void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(',', array));
}

// клиентский код
Console.WriteLine("start");
int size = InputData("размер массива");
int[] array = AddArray(size);
PrintArray(array);
Console.WriteLine("end");