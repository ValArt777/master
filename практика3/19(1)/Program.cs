//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
Console.WriteLine($"Введите число на проверку: ");
int N = int.Parse(Console.ReadLine()!);

int result = N;
int count;
int n = 1;
 while (N>0)
    {

    count = N % 10;
    n = N*10+count;
    N = N/10;

    }

 if (result==n)

    {

    Console.WriteLine($"Введенное число не является палиндромом.");

    }
    else

    {

        Console.WriteLine($"Введенное число является палиндромом.");

    }


