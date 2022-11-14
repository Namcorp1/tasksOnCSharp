/* Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

(int, int) InputData()
{
    bool check = false;
    int m = -1;
    int n = -1;
    Console.WriteLine("Введите значения m и n для ф-ии Аккермана:");
    while (!(check && m >= 0 && n >= 0))
    {
        Console.Write("m: ");
        string dataM = Console.ReadLine();
        Console.Write("n: ");
        string dataN = Console.ReadLine();
        check = int.TryParse(dataM, out m) && int.TryParse(dataN, out n);
    }
    return (m, n);
}

//вычисление ф-ии Аккермана
int FunctionAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m != 0 && n == 0) return FunctionAckermann(m - 1, 1);
        else return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    }
}

//печать результата
void PrintResult(int num1, int num2, int res)
{
    string output = $"m = {num1}, n = {num2} -> A({num1}, {num2}) = {res}";
    Console.WriteLine(output);
}

//клиентский код
(int m, int n) = InputData();
int result = FunctionAckermann(m, n);
PrintResult(m, n, result);