/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

//ввод данных
int InputData(string text)
{
    bool check = false;
    int num = 0;
    while (!check)
    {
        Console.Write($"Введите значение {text}: ");
        string data = Console.ReadLine();
        check = int.TryParse(data, out num);
    }
    return num;
}

//сумма элементов
int SumElement(int num1, int num2)
{
    int sum = 0;
    for (int i = num1; i <= num2; i++)
    {
        sum += i;
    }
    return sum;
}

//печать результата
void PrintResult(int num1, int num2, int sum)
{
    string output = $"M = {num1}, N = {num2} -> {sum}";
    Console.WriteLine(output);
}

//клиентский код
int m = InputData("M");
int n = InputData("N");
int result = SumElement(m, n);
PrintResult(m, n, result);