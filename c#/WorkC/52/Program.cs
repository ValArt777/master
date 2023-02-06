// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    Random random = new Random();

    for (int y = 0; y < rows; y++)
    {
        for (int x = 0; x < columns; x++)
        {
            newArray[y, x] = random.Next(1, 10);
        }
    }
    return newArray;
}

void PrintArray(int[,] arrayForPrint)
{
    for (int y = 0; y < arrayForPrint.GetLength(0); y++)
    {
        for (int x = 0; x < arrayForPrint.GetLength(1); x++)
        {
            System.Console.Write(" {0,6:F0} ", arrayForPrint[y, x]);
        }
        System.Console.WriteLine();
    }
}

double[] takeAverageArray(int[,] arrayToSummary)
{
    int hight = arrayToSummary.GetLength(0);
    int width = arrayToSummary.GetLength(1);
    double[] averageLine = new double[width];
    for (int x = 0; x < width; x++)
    {
        double tempSummColumn = 0;
        for (int y = 0; y < hight; y++)
        {
            tempSummColumn += arrayToSummary[y, x];
        }
        averageLine[x] = tempSummColumn / hight;
    }
    return averageLine;
}

void PrintArrayLine(double[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(" {0,6:F2} ", arrayForPrint[i]);
    }
}

void Main()
{
    System.Console.Write("Программа сгенерирует массив со случайными размерами. А далее найдет среднее арифметическое в каждом столбце. Нажмите любую клавишу:\n ");
    Console.ReadKey();
    int rowCount = new Random().Next(4, 6);
    int columnCount = new Random().Next(4, 8);
    System.Console.WriteLine();
    int[,] ourArray = GetArray(rowCount, columnCount);
    PrintArray(ourArray);
    System.Console.WriteLine();
    double[] takeAverageLine = takeAverageArray(ourArray);
    PrintArrayLine(takeAverageLine);
}

Main();