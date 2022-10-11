/*
Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// приглашение ко вводу
string[] InputCoordinate()
{
// просим ввести координаты через запятую, чтобы разделить их методом split
Console.Write("Введите координаты x,y,z через запятую без пробелов: ");
string coord = Console.ReadLine();
string[] number = coord.Split(',');
return number;
}
// вычисление расстояния между точками
double Distance(string[] p1, string[] p2)
{
    double x1 = Convert.ToInt32(p1[0]);
    double y1 = Convert.ToInt32(p1[1]);
    double z1 = Convert.ToInt32(p1[2]);
    double x2 = Convert.ToInt32(p2[0]);
    double y2 = Convert.ToInt32(p2[1]);
    double z2 = Convert.ToInt32(p2[2]);

    double distXZ = Math.Sqrt((z1 - z2) * (z1 - z2)+
                    (x1 - x2) * (x1 - x2));
// округляем до 2 знака расстояние как показано в примере задачи
    double dist = Math.Round(Math.Sqrt((y1 - y2) * (y1 - y2) + 
                    distXZ * distXZ),2);
    return dist;
}
// вывод результата
void PrintResult(double d, string[] p1, string[] p2)
{
    string output = $"Расстояние между точками 1 ({String.Join(',',p1)}) и 2 ({String.Join(',',p2)}) равно {d}";
    Console.WriteLine(output);
}

// клиентский код
Console.WriteLine("start");
string[] point1 = InputCoordinate();
string[] point2 = InputCoordinate();
double distance = Distance(point1, point2);
PrintResult(distance, point1, point2);
Console.WriteLine("end");
