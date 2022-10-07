/*
21. Задать номер четверти, 
показать диапазоны для возможных координат
*/

// приглашение ко вводу
int InputFourth (string text)
{
    Console.Write($"Введите {text} : ");
    int fourth = Convert.ToInt32(Console.ReadLine());
    return fourth;
}
// вывод результата
void Result (int fourth)
{
    string msg = "Нет такой четверти!";
    if (fourth == 1) msg = "x in (0, infinity), y in (0, infinity).";
    if (fourth == 2) msg = "x in (-infinity, 0), y in (0, infinity).";
    if (fourth == 3) msg = "x in (-infinity, 0), y in (-infinity, 0).";
    if (fourth == 4) msg = "x in (0, infinity), y in (-infinity, 0).";
    Console.WriteLine(msg);
}

int fourth = InputFourth("четверть плоскости");
Result(fourth);