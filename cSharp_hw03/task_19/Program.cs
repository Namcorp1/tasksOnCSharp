﻿/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// приглашение ко вводу (метод возвращает, но не принимает)
int EnterCode()
{
Console.Write("Введите число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
return n;
}
// разворот числа (метод возвращает и принимает)
int Reverse(int num)
{
int reNum = 0;
int numeral = 0;
int count = 0;
/*
По условиям задачи нужно проверить пятизначное,но сделаем чуть больше 
и напишем алгоритм для разворота любого числа. 
Проверочное число собирается путём цикла - 
нахождение остатка от введенного числа и умножение на 10
в степени в зависимости от счётчика. Этот остаток потом убирается 
у введенного числа путем деления на 10 и далее по новой
*/
while (num >= 1)
{
    numeral = num % 10;
    reNum = reNum * 10 + numeral ;
    num /= 10;
    count += 1;
    Console.WriteLine(reNum); // просто для отображения разворота числа, можно закоментить
}
return reNum;
}
// печать результата (метод принимает, но не возвращает)
void PrintResult(int reNumber, int number)
{
if (reNumber == number) Console.WriteLine("Палиндром!");
else Console.WriteLine("Не палиндром!");
}

// клиентский код
Console.WriteLine("start");
int number = EnterCode();
/*
в методе Reverse есть лишняя строка (37), которую добавил просто для отображения 
разворота, её нужно закомментить, что соблюдалось правило 
"в методе либо логика, либо интерфейс"
*/
int reNumber = Reverse(number);
PrintResult(reNumber,number);
Console.WriteLine("end");