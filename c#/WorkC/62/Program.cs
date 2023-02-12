// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 11 12 199 14
// 12 199 14 15
// 11 16 15 16
// 11 19 18 17
int[,] GetMatrix((int rows , int columns)args)
{
    
    int[,] Matrix = new int[args.rows, args.columns];
    int number = 1;

    int upBorder = 0;
    int rightBorder = args.columns - 1;
    int DownBorder = args.rows - 1;
    int leftBorder = 0;

    bool right = true;
    bool down = false;
    bool next = true;

    int row = 0;
    int column = 0;

    Matrix[row, column] = number++;
    for (int i = 0; i < Matrix.Length - 1; i++)
    {
        if (right && next)
        {
            Matrix[row, ++column] = number++; 
            down = !(column < rightBorder); 
            right = down ? !down : right; 
            upBorder += down ? 1 : 0; 
        }
        else if (down)
        {
            Matrix[++row, column] = number++; 
            down = row < DownBorder; 
            rightBorder -= !down ? 1 : 0;
        } 
        else if (!right)
        
        {
            Matrix[row, --column] = number++; 
            right = leftBorder == column; 
            next = !right;
            DownBorder -= right ? 1 : 0; 
        }
        else
        {
            Matrix[--row, column] = number++; 
            down = upBorder == row; 
            next = down; 
            leftBorder += down ? 1 : 0; 
        }
    }   

    return Matrix;
}


void PrintToArray(int[,] Ourarray)    
{
    Console.WriteLine("\n");
    Console.WriteLine ("Таблица: ");
    for (int i = 0; i < Ourarray.GetLength(0); i++)
    {
        for (int j = 0; j < Ourarray.GetLength(1); j++)
        {
            Console.Write($"{Ourarray[i, j]}\t");
        }
        Console.WriteLine();
    }
}


void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк : ");
    int rowA = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов : ");
    int columnsA = int.Parse(Console.ReadLine()!);
    int[,] numbers = GetMatrix((rowA,columnsA));
    PrintToArray(numbers);
}
Main();
