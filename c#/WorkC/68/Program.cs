//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

AkkermanFunc(m,n);

void AkkermanFunc(int m, int n)
{
    Console.Write("Полученное число:" + akkerman(m, n)); 
}


int akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return akkerman(m - 1, 1);
    }
    else
    {
        return (akkerman(m - 1, akkerman(m, n - 1)));
    }
}
