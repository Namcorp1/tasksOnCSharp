// 16. Дано число. Проверить кратно ли оно 7 и 23
Console.Write("Введите число, которое необходимо проверить на кратность 7 и 23: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
if (number % 7 == 0)
{
    if (number % 23 == 0)
    {
        Console.WriteLine($"Число {number} кратно 7 и 23!");
    }
    else
    {
        Console.WriteLine($"Число {number} некратно 7 и 23!");    
    }
}
else
{
    Console.WriteLine($"Число {number} некратно 7 и 23!");
}