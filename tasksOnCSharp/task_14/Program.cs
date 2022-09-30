// 14. Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите число, кратность которого будете проверять: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
Console.Write("Введите число, кратно которому проверяете ранее введённое число: ");
string strModNumber = Console.ReadLine();
int modNumber = Convert.ToInt32(strModNumber);

int result = number % modNumber;

if (result == 0)
{
    Console.WriteLine($"Число {number} кратно {modNumber}");
}
else
{
    Console.WriteLine($"Число {number} некратно {modNumber}, остатком от деления будет {result}");
}