/*
Задача 27: Напишите метод, который принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// приглашение ко вводу
int InputNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
// суммирование цифр в числе
int SumNumeral(int num)
{
    int count = 1;
    int den = 1;
    while (num / den >= 10)
    {
        den *= 10;
        count += 1;
    }
    int[] arrayN = new int[count];
    den = 10;
    count = 0;
    while (num / den >= 1)
    {
        arrayN[count] = num % den;
        num /= 10;
        count += 1;
    }
    arrayN[count] = num;
    int size = arrayN.Length;
    count = 0;
    int sum = 0;
    while (count < size)
    {
        sum += arrayN[count];
        count += 1;
    }
    return sum;
}
// вывод результата
void PrintResult (int n, int sum)
{
    string output = $"{n} -> {sum}";
    Console.WriteLine(output);
}

Console.WriteLine("start");
int number = InputNumber();
int sum = SumNumeral(number);
PrintResult(number, sum);
Console.WriteLine("end");