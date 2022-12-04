/* Welcome. In this kata, you are asked to square every digit of a number 
and concatenate them.
For example, if we run 9119 through the function, 811181 will come out, 
because 9^2 is 81 and 1^2 is 1.
Note: The function accepts an integer and returns an integer. */

int SquareDigits(int n)
{
    int count = 1;
    int num = n;
    // считаем кол-во цифр в числе
    while (num > 9)
    {
        num /= 10;
        count++;
    }
    int numeral = 0;
    int res = 0;
    int st = 0; // для степени 10
    // будем находить квадраты чисел
    for (int i = 1; i <= count; i++)
    {
        numeral = n % 10;
        int p = Convert.ToInt32(Math.Pow(10, st));
        res += numeral * numeral * p;
        st = 1;
        num = res;
        while (num > 9)
        {
            num /= 10;
            st++;
        }
        /* если 0 не в конце числа исходного расположен, 
        то нужно будет следующее число умножать 10 
        в степени большей на 1 чем надо */
        if (numeral == 0 && i > 1) st++;
        n = (n - numeral) / 10;
    }
    return res;
}

void PrintResult(int before, int after)
{
    string output = $"{before} -> {after}";
    Console.WriteLine(output);
}

int before = 4083;
int after = SquareDigits(before);
PrintResult(before, after);