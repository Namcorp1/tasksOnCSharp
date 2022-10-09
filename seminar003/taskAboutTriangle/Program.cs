// Выяснить являются ли три числа сторонами треугольника
Console.Write("1 сторона: ");
int length1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2 сторона: ");
int length2 = Convert.ToInt32(Console.ReadLine());
Console.Write("3 сторона: ");
int length3 = Convert.ToInt32(Console.ReadLine());

if ((length1 + length2) > length3 &&
    (length1 + length3) > length2 &&
    (length2 + length3) > length1)
{
    Console.WriteLine("Это треугольник!");
}
else Console.WriteLine("Это не треугольник!");




