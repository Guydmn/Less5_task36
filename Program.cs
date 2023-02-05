// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = new int[10];
Console.WriteLine($"Длинна массива = {array.Length}");
Console.WriteLine();
int count1 = 0;
int count2 = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
int y1 = 0;
for (int i = 0; i < array.Length; i++)
{
    y1 = array[i]%2;
    if (y1 > 0)
    {
        count1 = count1 + array[i];
    }  
}
double y2 = 0;
for (int i = 0; i < array.Length; i++)
{
    y2 = i%2;
    if (y2 > 0)
    {
        count2 = count2 + array[i];
    }  
}
foreach (int item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Console.WriteLine($" Cумма нечетных чисел = {count1}");
Console.WriteLine($" Cумма чисел нечетных индексов = {count2}");