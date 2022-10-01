// 18. По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
string strFirstNumber = Console.ReadLine();
int firstNumber = Convert.ToInt32(strFirstNumber);

Console.Write("Введите второе число: ");
string strSecondNumber = Console.ReadLine();
int secondNumber = Convert.ToInt32(strSecondNumber);

if (firstNumber * firstNumber == secondNumber)
{
    Console.WriteLine($"Второе число {secondNumber} является квадратом первого числа {firstNumber}.");
}
else if (secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine($"Первое число {firstNumber} является квадратом второго числа {secondNumber}.");
}
else
{
    Console.WriteLine("Ни одно из чисел не являются квадратом для другого числа!");
}
