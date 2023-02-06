double[,] CreateArray(int rows, int columns)
{
    double[,] newFilledArray = new double[rows, columns];
    Random Randomizer = new Random();

    for (int y = 0; y < rows; y++)
    {
        for (int x = 0; x < columns; x++)
        {
            newFilledArray[y, x] = Randomizer.NextDouble() * Math.Pow(10, Randomizer.Next(2, 5));
        }
    }
    return newFilledArray;
}

void PrintArray(double[,] arrayForPrint)
{
    for (int y = 0; y < arrayForPrint.GetLength(0); y++)
    {
        for (int x = 0; x < arrayForPrint.GetLength(1); x++)
        {
            System.Console.Write(" {0,15:F4} ", arrayForPrint[y, x]);
        }
        System.Console.WriteLine();
    }
}

int GetNumberInputFromUser()
{
    return int.Parse(Console.ReadLine()!);
}

void Main()
{
    System.Console.Write("Программа сгенерирует массив вещественных числе по заданным размерам.\nВведите количество строк: ");
    int rowCount = GetNumberInputFromUser();
    System.Console.Write("Введите количество столбцов: ");
    int columnCount = GetNumberInputFromUser();
    System.Console.WriteLine();
    PrintArray(CreateArray(rowCount, columnCount));
}

Main();
