int[,,] GetArray()
{
    int[,,] array = new int[2, 2, 2];
    // int[,,] array = new int[,,]{
    //                             {{ 66, 25},
    //                             {34, 41}},
    //                             {{27, 90},
    //                             {26, 55}}
    //                             };
    int count=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                {
                    array[i, j, k] = count++;
                }
            }
    }
    return array;
}

void printArray(int[,,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                {
                    if (numbers[i, j, k] >= 0) Console.Write(" " + $"{numbers[i, j, k]}" + $"({i},{j},{k})" + "\t");
                    else Console.Write($"{numbers[i, j, k]}" + $"({i},{j},{k})" + " \t");
                }
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}


void main()
{
    int[,,] numbers = GetArray();
    System.Console.WriteLine();
    printArray(numbers);
}

main();
