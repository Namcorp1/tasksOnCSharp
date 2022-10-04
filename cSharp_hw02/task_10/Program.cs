/*
Задача 10: Напишите метод, 
который принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

// приглашение ко вводу
int EnterCode(string input)
{
    Console.Write(input);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
// нахождение второй цифры в трёхзначном числе
int Solution(int number)
{
    int secondNum = number / 10 % 10;
    return secondNum;
}
// вывод результата
void Print(int number, int secondNumber)
{
    string output = $"{secondNumber} - вторая цифра в числе {number}.";
    Console.WriteLine(output);
}

// клиентский код. Start и end чисто для схожести с блок-схемой.
Console.WriteLine("start");
int number = EnterCode("Введите число: ");
int secondNumber = Solution(number);
Print(number, secondNumber);  
Console.WriteLine("end");