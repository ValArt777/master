//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("Введите значение M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N: ");
int numerN = int.Parse(Console.ReadLine()!);

int PrintSum(int m, int n)
{
   int start = m;
   int end = n;
   if(m > n)
	{
		start = n;
		end = m;
	}
    
	return (end + start)*(end - start + 1)/2;
    
}

 Console.WriteLine("Сумма:" + PrintSum(numberM,numerN));

