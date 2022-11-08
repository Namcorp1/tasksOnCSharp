//4. Описать логику сложения двух дробей

//ввод дроби
int[] InputData(string text)
{
    string fullPart = "";
    string numinator = "";
    string denuminator = "";
    int[] fraction = new int[3];
    bool check = false;
    while (!check)
    {
        Console.WriteLine($"Введите {text} в формате:");
        Console.WriteLine("'числитель'/'знаменатель' или 'целая часть'('числитель'/'знаменатель')");
        string data = Console.ReadLine();
        bool full = false;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == '(') full = true;
        }

        if (full)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '(')
                {
                    for (int j = 0; j < i; j++) fullPart += data[j];
                    for (int k = i + 1; k < data.Length; k++)
                    {
                        if (data[k] == '/')
                        {
                            for (int l = i + 1; l < k; l++) numinator += data[l];
                            for (int t = k + 1; t < data.Length - 1; t++) denuminator += data[t];
                        }
                    }
                    break;
                }
            }
            check = int.TryParse(fullPart, out fraction[0])
                 && int.TryParse(numinator, out fraction[1])
                 && int.TryParse(denuminator, out fraction[2]);
            if (!check)
            {
                fullPart = "";
                numinator = "";
                denuminator = "";
            }
        }
        else
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '/')
                {
                    for (int j = 0; j < i; j++) numinator += data[j];
                    for (int k = i + 1; k < data.Length; k++) denuminator += data[k];
                    break;
                }
            }
            check = int.TryParse(numinator, out fraction[1])
                 && int.TryParse(denuminator, out fraction[2]);
            if (!check)
            {
                numinator = "";
                denuminator = "";
            }
        }
    }
    return fraction;
}

//простые числа
int[] PrimeNumber(int num)
{
    int[] nod = new int[1];
    if (num == 1)
    {
        nod[0] = num;
        return nod;
    }
    for (int i = 2; i <= num; i++)
    {
        bool b = true;
        for (int j = 2; j < i; j++) if (i % j == 0 && i % 1 == 0) b = false;
        if (b)
        {
            nod[nod.Length - 1] = i;
            Array.Resize(ref nod, nod.Length + 1);
        }
    }
    Array.Resize(ref nod, nod.Length - 1);
    return nod;
}

//разложение на простые множители
int[] PrimeFactors(int num)
{
    int index = 0;
    int[] numbers = PrimeNumber(num);
    int[] mp = new int[1];
    while (index < numbers.Length)
    {
        if (num % numbers[index] == 0)
        {
            num /= numbers[index];
            mp[mp.Length - 1] = numbers[index];
            Array.Resize(ref mp, mp.Length + 1);
            index = 0;
        }
        else index++;
    }
    Array.Resize(ref mp, mp.Length - 1);
    return mp;
}

//нахождение наименьшего общего делителя для каждого слагаемого
(int, int) MultiplierSum(int[] numM, int[] numN)
{
    for (int i = 0; i < numM.Length; i++)
    {
        for (int j = 0; j < numN.Length; j++)
        {
            if (numM[i] == numN[j])
            {
                numN[j] = 1;
                numM[i] = 1;
            }
        }
    }
    int res1 = 1;
    int res2 = 1;
    for (int i = 0; i < numM.Length; i++) res1 *= numM[i];
    for (int i = 0; i < numN.Length; i++) res2 *= numN[i];
    return (res1, res2);
}

//сложение дробей
int[] SumFraction(int[] fraction1, int[] fraction2, int num1, int num2)
{
    int[] result = new int[3];
    result[0] = fraction1[0] + fraction2[0];
    result[1] = fraction1[1] * num2 + fraction2[1] * num1;
    result[2] = fraction1[2] * num2;
    if (result[1] >= result[2])
    {
        result[0] += (result[1] / result[2]);
        result[1] = result[1] % result[2];
    }
    return result;
}

//вывод результата
void PrintResult(int[] fraction1, int[] fraction2, int[] sum)
{
    string output = $"{fraction1[0]}({fraction1[1]}/{fraction1[2]})" 
               + $" + {fraction2[0]}({fraction2[1]}/{fraction2[2]})" 
               + $" = {sum[0]}({sum[1]}/{sum[2]})";
    Console.WriteLine(output);
}

//клиентский код
int[] fraction1 = InputData("1 дробь");
int[] fraction2 = InputData("2 дробь");
int[] numsp1 = PrimeFactors(fraction1[2]);
int[] numsp2 = PrimeFactors(fraction2[2]);
(int number1, int number2) = MultiplierSum(numsp1, numsp2);
int[] sum = SumFraction(fraction1, fraction2, number1, number2);
PrintResult(fraction1,fraction2,sum);