/*
Задача 4: Напишите программу, 
которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("start");

// блок с исходными данными
int number1 = 22;
int number2 = 3;
int number3 = 9;
int max = 0;

// нахождение максимального числа из 1 и 2 числа
if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
// сравнение 3 числа с найденным максимумом
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"{max} - максимальное число");

Console.WriteLine("end");