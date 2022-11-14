/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[] InputSize()
{
    Console.Write("Введите размеры трёхмерного массива через запятую: ");
    bool check = false;
    int[] sizeArray = new int[3];
    int[] arr = new int[4];
    while(!(check && arr.Length > 3))
    {
    string input = Console.ReadLine();
    string[] size = input.Split(',');
    }
    return Console.ReadLine();
}
