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

//ввод данных для журнала посещения
int[] InputData()
{
    Console.WriteLine("Введите интервалы времени, когда закончите ввод, введите в консоль 'stop'.");
    int[] timeClient = new int[2];
    string text1 = "";
    int hour1 = 0;
    int hour2 = 0;
    int i = 0;
    while (text1 != "stop")
    {
        Console.Write("Введите интервал времени: ");
        text1 = Console.ReadLine();
        if (text1 == "stop") break;
        else //если не введено стоп, то разбиваем введенный текст на часы
        {
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
            hour1 = Convert.ToInt32(time1);
            hour2 = Convert.ToInt32(time2);
            timeClient[i] = hour1; //закидываем в отдельный почасовой массив
            timeClient[i + 1] = hour2;
            i += 2;
            Array.Resize(ref timeClient, timeClient.Length + 2);
        }
    }
    Array.Resize(ref timeClient, timeClient.Length - 2);
    Console.WriteLine(string.Join(',', timeClient)); //можно убрать
    return timeClient;
}
//формируем массив с количеством посещений в каждый час
int[] HoursCount(int[] arr)
{
    /* создаем массив на 25, а не на 24 элемента, 
    так как при максимальном кол-ве посетителей в последнем часу, 
    вывод идет некорректно */
    int[] timeline = new int[25];
    for (int j = 0; j < arr.Length - 1; j += 2)
    {
        int hours = arr[j + 1] - arr[j];
        for (int k = 0; k <= hours; k++)
        {
            timeline[arr[j] + k] += 1;
        }
    }
    Console.WriteLine(string.Join(',', timeline)); //можно убрать
    return timeline;
}
//вывод результата
void PrintResult(int[] time1)
{
    for (int e = 0; e < time1.Length; e++)
    {
        int maxHour = time1[e];
        int maxH = -1;
        for (int i = e; i < time1.Length; i++) //находим максимальный элемент в массиве
        {
            if (time1[i] > maxHour) { maxHour = time1[i]; maxH = i; }
        }
        for (int j = maxH; j < time1.Length; j++) //находим крайний макс.элемент, которые идут подряд
        {
            if (time1[j] != maxHour) { e = (j - 1); break; }
            else time1[j] = 0; //убираем макс.элементы чтобы потом не мешали
        }
        Console.WriteLine($"{maxH} - {e}");
        Console.WriteLine(string.Join(',', time1)); //можно убрать
    }
}

int[] list = InputData();
int[] hours = HoursCount(list);
PrintResult(hours);