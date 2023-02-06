// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] GetArray(int m, int n)
{
    double[, ] Newarray = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Newarray[i,j] =  random.NextDouble() * Math.Pow(10, random.Next(2, 5));
        }
    }
    return Newarray;
}    
    

void Printarray(double[,] arrayPrint)
{
        for (int i = 0; i < arrayPrint.GetLength(0); i++)
        {
            for (int j = 0; j < arrayPrint.GetLength(1); j++)
            {
               System.Console.Write(" {0,15:F2} " , arrayPrint[i, j]);
            }
            Console.WriteLine();
        }
}

    int GetNumber()
    {
        return int.Parse(Console.ReadLine()!);

    }
void Main()
    {
        Console.Write("Введите количество строк : ");
        int mCount = GetNumber();
        Console.Write("Введите количетсво столбцов : ");
        int nCount = GetNumber();
        Console.WriteLine();
        Console.Clear();
        Printarray(GetArray(mCount, nCount ));

    }

Main();
