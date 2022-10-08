// 22. Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("start");

int number = 34543;
int den1 = 1;
int den2 = 10;
int count = 1;
int startNumeral = 0;
int endNumeral = 0;

while (number / den1 >= 10)
{
    den1 *= 10;
    count += 1;
}