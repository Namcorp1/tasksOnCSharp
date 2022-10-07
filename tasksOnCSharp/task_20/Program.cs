/*
20. Определить номер четверти плоскости, 
в которой находится точка с координатами Х и У, 
причем X ≠ 0 и Y ≠ 0
*/

// приглашение ко вводу
int Point (string name)
{
    Console.Write(name + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
// определение четверти плоскости для одной точки
int Fourth (int pointX, int pointY)
{
    int qPlane = 0;
    if (pointX > 0 && pointY > 0) qPlane = 1;
    if (pointX < 0 && pointY > 0) qPlane = 2;
    if (pointX < 0 && pointY < 0) qPlane = 3;
    if (pointX > 0 && pointY < 0) qPlane = 4;
    return qPlane;
}
// вывод результата
void PrintResult (int qPlane, int pointX, int pointY)
{
    string output = $"Точка ({pointX}, {pointY}) находится в {qPlane} четверти плоскости";
    Console.WriteLine(output);
}

int pointX = Point("Введите X");
int pointY = Point("Введите Y");
int qPlane = Fourth(pointX,pointY);
PrintResult(qPlane, pointX, pointY);