//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

long minusX(long X)
{
   {

    if (X < 0)
    X = X * -1;
    return X;
   }
}
long summ (long A)
{
    long B = 0;
    while (A > 0)

    {
        B= B + A % 10;
        A= A / 10;
    
    }
    return B;

}
void decision ()
{
    Console.Clear();
    Console.Write ("Введите число : ");
    long number = Convert.ToInt64 (Console.ReadLine());
    number = minusX(number);
     System.Console.WriteLine($"Сумма цифр  {number} равна {summ(number)}");  
}
decision();
