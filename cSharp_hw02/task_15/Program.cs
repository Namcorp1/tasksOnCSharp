/*
Задача 15: Напишите метод, который принимает на вход цифру,
обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

// приглашение ко вводу
int EnterCode(string helloText)
{
    Console.Write(helloText + " от 1 до 7 (включительно): ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string InitialResult(int numberDay)
{
    string result = "невыходной день.";
    if (numberDay == 6 || numberDay == 7)
    {
        result = "выходной день!";
    }
    return result;
}

void PrintResult(string result, int numberDay)
{
    string output = $"{numberDay} - {result}";
    Console.WriteLine(output);
}

Console.WriteLine("start");
int numberDay = EnterCode("Введите номер недели");
string result = InitialResult(numberDay);
PrintResult(result, numberDay);
Console.WriteLine("end");