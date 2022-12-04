/*
There were and still are many problem in CW about palindrome numbers 
and palindrome strings. We suposse that you know which kind of numbers they are. 
If not, you may search about them using your favourite search engine.
In this kata you will be given a positive integer, 
val and you have to create the function next_pal()(nextPal Javascript) 
that will output the smallest palindrome number higher than val.
*/

int NextPal(int val)
{
    int res = 0;
    while (res != val)
    {
        res = 0;
        val++;
        int num = val;
        int numeral = 0;
        while (num >= 1)
        {
            numeral = num % 10;
            res = res * 10 + numeral;
            num /= 10;
        }
        if (res == val) return res;
    }
    return res;
}

int number = NextPal(191);
Console.WriteLine(number);