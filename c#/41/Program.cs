//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.Write("Введите числа через пробел:  ");
int [] GetArray = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int count= 0;
for (int i = 0;i < GetArray.Length ;i++)
{
    if (GetArray[i]>0)
    {
        count++;
    }
}

Console.WriteLine($"Количество положительных чисел : {count}");
