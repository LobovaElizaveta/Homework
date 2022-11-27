// Напишите программуб которая складывает цифры в числе
Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа равна: {Sum(A)}");

// Метод 
int Sum(int numbers)
{
   int n = 0;
   int p = 0;
   while (numbers>0)
   {
    n = numbers%10;
    p += n;
    numbers /=10;
   }
   return p;

}