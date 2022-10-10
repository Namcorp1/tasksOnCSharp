// 22. Программа проверяет пятизначное число на палиндромом.

// приглашение ко вводу (метод возвращает, но не принимает)
int EnterCode()
{
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
return n;
}
// разворот числа (метод возвращает и принимает)
int Reverse(int num)
{
int reNum = 0;
int numeral = 0;
int count = 0;
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
int reNumber = Reverse(number);
PrintResult(reNumber,number);
Console.WriteLine("end");