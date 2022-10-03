// 23. Найти расстояние между точками в пространстве 2D/3D

/*
Подзадачи:
1. Откуда значения (из метода)
2. Вычисление
3. Печать результата
*/

// метод приглашения ко вводу
double GetValue(string text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

// метод в каком виде выводить результат
void Print(double ax,double ay,double bx,double by,double result)
{
    // |A(1,2);B(4,5)| = 5
    /* На костылях...очень неудобных костылях :)
    string output = "|A(" + ax + ", " + ay + 
                    "); B(" + bx + ", " + by + ")| = " + result;
    */
    string output = $"|A({ax}, {ay});B({bx}, {by})| = {Math.Round(result, 2)}";
    Console.WriteLine(output);
}

// метод расчёта необходимой величины
double GetDistance2D(double ax,double ay,double bx,double by)
{
    double x = Math.Pow(ax - bx, 2);
    double y = Math.Pow(ay - by, 2);
    double result = Math.Sqrt(x + y);
    return result;
}
/* 
методы, написанные выше могут располагаться в любом порядке, 
так как они будут вызываться в клиентском коде 
точечно при необходимости
*/

// клиентский код (то что будет вызывать наши вышенаписанные методы)
// приглашение ко вводу
double ax = GetValue("ax");
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");
// вычисление
double dist = GetDistance2D(ax, ay, bx, by);
// вывод результата
Print(ax, ay, bx, by, dist);
