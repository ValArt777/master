Console.Clear();

int[] getarray (int size , int minValue , int maxValue)
{
   int[] res = new int[size];
   for (int i=0; i < size ; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


 }

