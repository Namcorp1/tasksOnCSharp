/*
Есть магазин "Ромашка"
Охранник ведёт журнал посещения
11-13
10-14
9-10
11-22
18-18
0-23
4-5
4-5
4-5
Суть: показать интервалы, когда было больше всего людей в магазине
Ответ: 4-5, 11-13
*/
int[] InputData(string text1)
{
    //string timeShop = Console.ReadLine();
    int count = text1.Length;
    string time1 = "";
    string time2 = "";
    if (count == 3)
    {
        time1 = $"{text1[0]}";
        time2 = $"{text1[2]}";
    }
    else if (count == 4)
    {
        time1 = $"{text1[0]}";
        time2 = $"{text1[2]}" + $"{text1[3]}";
    }
    else if (count == 5)
    {
        time1 = $"{text1[0]}" + $"{text1[1]}";
        time2 = $"{text1[3]}" + $"{text1[4]}";
    }
    int hour1 = Convert.ToInt32(time1);
    int hour2 = Convert.ToInt32(time2);

    int[] timeline = new int[24];
    while (hour1 <= hour2)
    {
        timeline[hour1] += 1;
        hour1++;
    }

    Console.WriteLine(string.Join(',', timeline));
    return timeline;
}
// создаём массивы с "1" в часы посещения
int[] time1 = InputData("9-12");
int[] time2 = InputData("9-15");
int[] time3 = InputData("14-18");
int[] time4 = InputData("17-18");
int[] time5 = InputData("20-20");
int[] time6 = InputData("9-19");
int[] time7 = InputData("19-21");

// создаем массив, где суммируем эти единички 
// чтобы понять какие часы максимальны по посещению
int index = 0;
int[] timeResult = new int[24];
while (index < 24)
{
    timeResult[index] = time1[index] + time2[index] + time3[index] +
             time4[index] + time5[index] + time6[index] + time7[index];
    index++;
}
// находим максимальное посещение в час
// и первый час с таким посещением - 1ый цикл
// и сколько в целом было таких часов - 2ой цикл
index = 0;
int maxHour = timeResult[index];
int maxI = -1;
int count = 0;
while (index < 24)
{
    if (maxHour < timeResult[index])
    {
        maxHour = timeResult[index];
        maxI = index;
    }
    index++;
}
index = 0;
while (index < 24)
{
    if (timeResult[index] == maxHour) 
    {
        count += 1;
    }
    index++;
}
// пытаюсь теперь вычленить все часы с этим посещением
index = maxI;
// int[] MaxHours = new int[count];
// int indexMax = maxI;
// while (maxI < 24)
// {
//     if (timeResult[maxI] == timeResult[indexMax])
//     {
//         in
//     }
// }

Console.WriteLine(maxHour);
Console.WriteLine(maxI);
Console.WriteLine(count);
Console.WriteLine(string.Join(',', timeResult));
