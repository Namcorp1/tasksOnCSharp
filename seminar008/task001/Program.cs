/*
Сколько есть вариантов перехода числа a в b, используя операции (+с), (*d)
Условие: a < b 
Например: 5 в 18 используя (+1), (*3) будет 3 варианта
*/

//ввод данных
long InputData(string text)
{
    int n = 0;
    bool check = false;
    while (!check)
    {
        Console.Write($"Введите {text}: ");
        string data = Console.ReadLine();
        check = int.TryParse(data, out n);
    }
    return n;
}

//вычисление вариантов преобразования
long Operation(long num1, long num2, long oper1, long oper2)
{
    if (num1 > num2) return 0;
    else if (num1 == num2) return 1;
    else if (num2 % oper2 == 0) return Operation(num1, num2 / oper2, oper1, oper2)
                                     + Operation(num1, num2 - oper1, oper1, oper2);
    else return Operation(num1, num2 - oper1, oper1, oper2);
}

//вывод результата
void PrintResult(long start, long end, long op1, long op2, long count)
{
    string output = $"{count} - кол-во вариантов преобразования {start} в {end} с помощью операций (+{op1}) и (*{op2}).";
    Console.WriteLine(output);
}

//клиентский код
long number1 = InputData("начальное число");
long number2 = InputData("конечное число");
long oper1 = InputData("прибавляемое число");
long oper2 = InputData("множитель");
long count = Operation(number1, number2, oper1, oper2);
PrintResult(number1, number2, oper1, oper2, count);