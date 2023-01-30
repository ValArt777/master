//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] array = GetArray(10, 100, 999);

Console.WriteLine(String.Join(" ", array));
int FindInRange (int[] array, int lowBorder, int highBorder)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0)
        {
            count++;
        }
    }
    return count;
}

int even = FindInRange(array, 100, 999);
Console.WriteLine ($"Количество четных чисел = {even}");
