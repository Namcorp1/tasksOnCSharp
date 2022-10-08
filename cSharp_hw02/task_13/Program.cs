/*
Задача 13: Напишите метод, который выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

// приглашение ко вводу числа
int EnterCode(string text)
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

// вычисление 3ей цифры
int ThirdNumberVar1(int number)
{
    int den = 1;
    while (number / den > 1000)
    {
        den *= 10;
    }
    // int thirdNum = (number / den) - (number - (number % (den *10))) / den ;
    int thirdNum = number / den % 10;
    return thirdNum;
}

/*
Вывод результата. Не придумал как вывести в ответе
отрицательное число, если оно вводилось изначально.
А то немного нелогично получается в ответе в терминале,
когда набираешь отрицательное число.
*/
void Print(int number, int thirdNumber)
{
    string output = $"{thirdNumber} - третья цифра числа {number}.";
    Console.WriteLine(output);
}

// проверка с последующим вычислением
void CheckNumber(int number)
{
    if (number < -99 || number > 99)
    {
        int thirdNumber = ThirdNumberVar1(number);
        Print(number,thirdNumber);
    }
    else
    {
        Console.Write("Третьей цифры нету!");
    }
}

// клиентский код
int number = EnterCode("Введите число: ");
CheckNumber(number);