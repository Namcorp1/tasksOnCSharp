/*
1. Описать представление обыкновенной дроби
  1/4  11/22  14/21
2. Описать логику сокращения дроби
  1/4 -> 1/4   11/22 -> 1/2  14/21 -> 2/3
3. Продумать над тем, как хранить целую часть
      1
   5 ---    
      3
4. Описать логику сложения двух дробей <
5. Логика описывается методами

Q m/n
1   25             
-  ---              
3  111  
*/

/*Много строк написано можно сказать лишними, так как прикрутил сюда ввод и обработоку 
целую часть дроби, что нелогично учитывая, что целая часть никак не участвует в сокращении дроби,
она остается неизменной.*/

//ввод дроби
(int, int, int) InputData()
{
    string fullPart = "";
    string numinator = "";
    string denuminator = "";
    int f = 0;
    int m = 0;
    int n = 0;
    bool check = false;
    while (!check)
    {
        Console.WriteLine("Введите дробь в формате:");
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
            check = int.TryParse(fullPart, out f) && int.TryParse(numinator, out m) && int.TryParse(denuminator, out n);
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
            check = int.TryParse(numinator, out m) && int.TryParse(denuminator, out n);
            if (!check)
            {
                numinator = "";
                denuminator = "";
            }
        }
    }
    return (f, m, n);
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
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0 && i % 1 == 0)
            {
                b = false;
            }
        }
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

//нахождение наибольшего общего делителя
int CommonFactor(int[] numM, int[] numN)
{
    int[] common = new int[1];
    for (int i = 0; i < numM.Length; i++)
    {
        for (int j = 0; j < numN.Length; j++)
        {
            if (numM[i] == numN[j])
            {
                common[common.Length - 1] = numM[i];
                Array.Resize(ref common, common.Length + 1);
                numM[i] = 0;
            }
        }
    }
    Array.Resize(ref common, common.Length - 1);
    int res = 1;
    for (int i = 0; i < common.Length; i++)
    {
        res *= common[i];
    }
    return res;
}

//сокращение дроби
(int, int) Reduction(int m, int n, int factor) { return (m / factor, n / factor); }

//вывод результата
void PrintResult(int fullPart, int beforeNum, int beforeDenum
                             , int afterNum, int afterDenum)
{
    string output = "";
    if (fullPart == 0)
    {
        if (beforeNum == afterNum)
        { output = $"{beforeNum}/{beforeDenum} - несократимая дробь!"; }
        else
        { output = $"{beforeNum}/{beforeDenum} -> {afterNum}/{afterDenum}"; }
    }
    else
    {
        if (beforeNum == afterNum)
        { output = $"{fullPart}({beforeNum}/{beforeDenum}) - несократимая дробь!"; }
        else
        { output = $"{fullPart}({beforeNum}/{beforeDenum}) -> {fullPart}({afterNum}/{afterDenum})"; }
    }
    Console.WriteLine(output);
}

//клиентский код
(int f, int m, int n) = InputData();
if (m == 1)
{
   if (f == 0) Console.WriteLine($"{m}/{n} - несократимая дробь!"); 
   else Console.WriteLine($"{f}({m}/{n}) - несократимая дробь!");
}
else
{
    int[] multiM = PrimeFactors(m);
    int[] multiN = PrimeFactors(n);
    int factor = CommonFactor(multiM, multiN);
    (int a, int b) = Reduction(m, n, factor);
    PrintResult(f, m, n, a, b);
}

