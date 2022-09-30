// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// Следующие 2 строки определяют ввод данных.
// Закомментить 1ую строку если нужно чтобы данные вводились вручную.
// Закомментить 2ую строку чтобы число само сгенерировалось.
Console.Write("Введите номер дня недели: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
//int number = new Random().Next(1,8);

Console.WriteLine($"Дано число: {number}");
if (number == 7 || number == 6)
{
    Console.WriteLine($"{number} - этот номер дня недели является выходным!");
}
else
{
    Console.WriteLine($"{number} - этот номер дня недели не является выходным!");
}