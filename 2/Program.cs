Console.WriteLine ("введите трехзначное число: ");

int num1 = int.Parse(Console.ReadLine ()!);

int a = num1 / 10 % 10;

Console.WriteLine ($"Введенное число {num1} -> Вторая цифра {a}");