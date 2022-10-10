/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
В задаче указано N, что скорей всего означает натуральные числа,
но я сделаю немного больше и пусть это будут целые числа.
*/

// приглашение ко вводу
int Input()
{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
// создание массива с кубами чисел
int[] ArrayCube(int n)
{
    int start = 1;
    int index = 0;
    /* задаем длину массива, она будет отличаться 
    в зависимости от того, будет ли число отрицательное 
    или положительное (если меньше 0, то добавляются
    0 и -1, так как по условию задачи нам надо вывести от 1 до N)
    */
    int length = n;
    if (n <= 0) length = Math.Abs(n) + 2;
    int[] arrayCube = new int[length];
    if (n < 0)
    {
        while (start >= n)
        {
            arrayCube[index] = start * start * start;
            start -= 1;
            index += 1;
        }
    }
    else
    {
        while (start <= n)
        {
            arrayCube[index] = start * start * start;
            start += 1;
            index += 1;
        }
    }
    return arrayCube;
}
// вывод результата
void PrintResult(int[] array)
{
    Console.WriteLine(string.Join(',',array));
}

// клиентский код
Console.WriteLine("start");
int number = Input();
int[] arrayCube = ArrayCube(number);
PrintResult(arrayCube);
Console.WriteLine("end");