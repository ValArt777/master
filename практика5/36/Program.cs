//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.Clear();

int[] GetArray(int size, int maxValue, int minValue )
{
    int [] res = new int[size];
    for (int i = 0; i < size; i++ )
    {
        res[i]= new Random().Next( maxValue+1 , minValue);

    }
    return res;
   

}

int[] FindInRange(int[] ArrayForCheck)
{
    int countIndex = 0;
    int summ = 0;
    for (int j = 1; j < ArrayForCheck.Length; j += 2)
    {
        countIndex++;
        summ += ArrayForCheck[j];
    }
    return new[] { countIndex, summ };
}
void Root()
{
    Console.Clear();
    int randomSize = new Random().Next(6, 30);
    int[] OurArray = GetArray(randomSize, -100, 100);
    System.Console.WriteLine($"Сгенерирован массив из {randomSize} значений:{String.Join(" ", OurArray)}");
    int[] ResultArray = FindInRange(OurArray);
    System.Console.WriteLine($" Сумма значений на нечётных ({ResultArray[0]} шт) позициях равна {ResultArray[1]} ");
}

Root();