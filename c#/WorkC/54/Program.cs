// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Get2DArray()
{
    int[,] array = new int[3, 3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 10);
        }
    }
    return array;
}

void printArray(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            if (num[i, j] >= 0) Console.Write(" " + $"{num[i,j]}" + "\t");
            else Console.Write($"{num[i, j]}" + " \t");
        }
        System.Console.WriteLine();
    }
}

void SummNumbersRowArray(int[,] nums)
{
    for (int x = 0; x < nums.GetLength(0); x++)
    {
        for (int j = 0; j < nums.GetLength(0); j++)
        {
            for (int i = 1; i < nums.GetLength(1); i++)
            {
                if (nums[j, i] > nums[j, i - 1])                                   
                {                                                                
                    int temp = nums[j, i];
                    nums[j, i] = nums[j, i - 1];
                    nums[j, i - 1] = temp;
                }
            }
        }
    }
}


void main()
{
    Console.Clear();
    int[,] numbers = Get2DArray();
    printArray(numbers);
    System.Console.WriteLine();
    SummNumbersRowArray(numbers);
    printArray(numbers);

}

main();