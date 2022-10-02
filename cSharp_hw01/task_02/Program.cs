/* Задача 2: Напишите программу, 
которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("start");

// блок с исходными данными
int number1 = -9;
int number2 = -3;
int max = 0;
int min = 0;

//блок проверки равности чисел
if (number1 == number2)
{
    Console.WriteLine("Числа одинаковы");
}
else //блок проверки большего и меньшего числа
{
    if (number1 > number2)
    {
        max = number1;
        min = number2;
    }
    else
    {
        max = number2;
        min = number1;
    }
    Console.WriteLine($"Число {max} большее, число {min} меньшее.");
}

Console.WriteLine("end");