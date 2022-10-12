/*
Задача 25: опишите метод, который принимает на вход 
два числа (A и B) и возводит число A в целую степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
без math.pow
*/

// приглашение ко вводу
int InputNumber (string text)
{
    Console.Write("Введите " + text + ": ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
// вычисление целой степени числа
int ExpNumber (int a, int b)
{
    int count = 1;
    int check = a;
    while (count < b)
    {
        a *= check;
        count += 1;
    }
    return a;
}
// вывод результата
void PrintResult (int a, int b, int result)
{
    string output = $"{a} ^ {b} = {result}";
    Console.WriteLine(output);
}

// клиентский код
Console.WriteLine("start");
int a = InputNumber ("число");
int b = InputNumber ("степень");
int result = ExpNumber (a, b);
PrintResult (a, b, result);
Console.WriteLine("end");