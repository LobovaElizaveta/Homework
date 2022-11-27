// Напишите программу, которая возводит первое число в степень, являющуюся вторым числом
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A} в степени {B} равно {Power(A,B)}");

// Метод
int Power(int n, int p)
{
   if ( n ==0)
   {
      return 0;
   }
   if (n ==1 || p ==0)
   {
      return 1;
   
   }
   if (n>1)
   {
      return n*Power(n, p-1);
   }
   else return n;
}