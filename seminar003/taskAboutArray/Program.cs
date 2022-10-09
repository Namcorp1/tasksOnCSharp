int n = 25;
int[] array = new int[n];
int index = 0;
int maxNumber = 12;

while(index < n)
{
    int number = new Random().Next(0,maxNumber);
    array[index] = number;
    index ++;
}
Console.WriteLine(string.Join(',',array));

index = 0;
int[] result = new int[maxNumber];
Console.WriteLine(string.Join(',',result));
int check = 0;
while(index < n)
{
    result[array[index]] += 1;
    index ++;
}

Console.WriteLine(string.Join(',',result));

index = 0;
while(index < maxNumber)
{
    int num = result[index];
    string output = $"{index} - {num} раз";
    Console.WriteLine(output);
    index ++;
}