// Напишите программу, которая выводит массив из 8 любых чисел
int [] array = GetArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");
// Метод
int [] GetArray(int a)
{
    int [] result = new int [a];
    for (int i = 0; i < a; i++)
    {
        result[i] = new Random().Next(1000);
    }
    return result;
}