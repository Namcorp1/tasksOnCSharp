// 15. Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число, третью цифру которого необходимо указать: ");
string strNumber = Console.ReadLine();
int countNumber = strNumber.Length;
if(countNumber < 3)
{
    Console.WriteLine("Третьей цифры в числе нету!");
}
else
{
    Console.WriteLine($"{strNumber[2]} - третья цифра в числе {strNumber}");
}
