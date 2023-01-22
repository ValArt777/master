Console.WriteLine ( "Введите чиcло");
int a = int.Parse(Console.ReadLine ()!);
int b = a / 100 ;
if (b < 1)
{
    Console.WriteLine ($"Третья цифра отсутствует.");

}

else
{
    b = a / 100 % 10;
    Console.WriteLine ($"Введенное число {a} , третья цифра {b}");

}
