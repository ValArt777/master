// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] Get2DArray()
{
    int[,] randomarray = new int[5, 4];
    for (int i = 0; i < randomarray.GetLength(0); i++)
    {
        for (int j = 0; j < randomarray.GetLength(1); j++)
        {
            randomarray[i, j] = new Random().Next(0, 10);
        }
    }
    return randomarray;
}

void ArrayToPrint(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            if (nums[i, j] >= 0) Console.Write(" " + $"{nums[i, j]}" + "\t");
            else Console.Write($"{nums[i, j]}" + " \t");
        }
      Console.WriteLine();
    }
}

int[] SummRow(int[,] numbers)
{
    int[] summArray = new int[numbers.GetLength(0)];
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            summArray[j] += numbers[j, i];
        }
    }
    return summArray;
}

void newArrayToPrint(int[] minSumNumRow, int[,] numbers)
{
    int temp = int.MaxValue;
    int count = 0;
    for (int i = 0; i < minSumNumRow.Length; i++)
    {
        if (temp > minSumNumRow[i])
        {
            temp = minSumNumRow[i];
            count = i;
        }
    }
   Console.WriteLine($"Минимальная сумма элементов получена из  {count}  строки");
}

void main()
{
    Console.Clear();
    int[,] numbers = Get2DArray();
    ArrayToPrint(numbers);
    Console.WriteLine();

    int[] minSummNumbersRow = SummRow(numbers);
    Console.WriteLine(string.Join(",", minSummNumbersRow));

    newArrayToPrint(minSummNumbersRow, numbers);
    Console.WriteLine();
}

main();
