//Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

double result1 (double num, int num1)
{
    double B = 1;
     for (int i = 0; i < num1; i++)
    {
        B *= num;
    }
    return B;
}

int minusX(int x)

{
    if (x < 0)
    {
        x = x * (-1);
        System.Console.WriteLine("Приводим число к натуральному");
    }
    return x;
}
void decision()
{
    System.Console.Write("Введите первое число A : ");
    double FactorA = Convert.ToSingle(Console.ReadLine());
    System.Console.Write("Введите второе число B : ");
    int FactorB = Convert.ToInt32(Console.ReadLine());
    FactorB = minusX(FactorB);

    System.Console.WriteLine($"A({FactorA}) в степени B({FactorB}) = {result1(FactorA, FactorB)}");
}

decision();

