
int Task(long n)
{
    long sum = 0;
    while (n > 10)
    {
        sum += n % 10;
        n /= 10;
    }
    sum += n;
    int res = Convert.ToInt32(sum);
    if (res % 9 == 0)
    {
        int summ = 0;
        while (res > 10)
        {
            summ += res % 10;
            res /= 10;
        }
        summ += res;
        res = summ;
    }
    if (res == 99 || res == 18) return 9;
    else
    {
        res %= 9;
    }
    return res;
    // long sum = 0;
    // while (n > 10)
    // {
    //     sum += n % 10;
    //     n /= 10;
    // }
    // sum += n;
    // int res = Convert.ToInt32(sum);
    // if (res>=10) res = Task(sum);
    // return res;

}
int result = Task(99999999999);
Console.WriteLine(result);