// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetFilledArrayDouble(int size)
{
    double[] ArrayForFill = new double[size];
    Random TempRandom = new Random();

    for (int i = 0; i < size; i++)
    {                     
        ArrayForFill[i] = TempRandom.NextDouble() * Math.Pow(10, TempRandom.Next(3, 10));
        ArrayForFill[i] = TempRandom.Next(1, 6) % 2 == 0 ? -ArrayForFill[i] : ArrayForFill[i];
    }
    return ArrayForFill;
}

int[] FindMinMax(double[] ArrayForCheck)
{
    int minIndex = 0;
    int maxIndex = 0;
    for (int j = 0; j < ArrayForCheck.Length; j++)
    {
        minIndex = (ArrayForCheck[minIndex] < ArrayForCheck[j]) ? minIndex : j;
        maxIndex = (ArrayForCheck[maxIndex] > ArrayForCheck[j]) ? maxIndex : j;
    }
    return new[] { minIndex, maxIndex };
}

void main()
{
    Console.Clear();
    int randomSize = new Random().Next(6, 12);
    double[] OurArray = GetFilledArrayDouble(randomSize);
    System.Console.WriteLine($"массив {randomSize} значений:");

    int[] MinMaxArray = FindMinMax(OurArray);
    int minOurArray = MinMaxArray[0];
    int maxOurArray = MinMaxArray[1];

    int j = 0; 
    for (int i = 0; i < randomSize; i++)
    {
        
        System.Console.Write(" {0,15:F3} ", OurArray[i]);
        j++;
        if (j % 5 == 0) System.Console.WriteLine(); 
    }
    System.Console.WriteLine();
    System.Console.Write("Разница между максимальным и минимальным значениями массива равна: ");
    System.Console.WriteLine(" {0:F3} ", OurArray[maxOurArray] - OurArray[minOurArray]);
   
}
main();
