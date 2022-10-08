// 22. Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("start");
Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int den1 = 1;
int den2 = 1;
int count = 1;
int startNumeral = 0;
int endNumeral = 0;

while (number / den1 >= 10)
{
    den1 *= 10;
    count += 1;
}
Console.WriteLine(count);
Console.WriteLine(den1);

int n = count / 2;
Console.WriteLine(n);
while (count > n)
{
    startNumeral = number / (den1) - (number / den1) % (den1 / 10);
    endNumeral = (number % den2 - number % (den2 * 10)) / (den2);
    Console.WriteLine(startNumeral);
    Console.WriteLine(endNumeral);

    if (startNumeral == endNumeral)
    {
        count -= 1;
        den1 /= 10;
        den2 *= 10;
    }
    else
    {
        Console.WriteLine($"Число {number} не палиндром!");
        break;
    }

}
Console.WriteLine($"Число {number} палиндром!");
Console.WriteLine("end");