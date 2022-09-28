// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Введите число M");
int a = int.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Введите число N");
int b = int.Parse(Console.ReadLine() ?? string.Empty);


int Sum(int c, int d)
{
    if (c == d) 
    {
        return d;
    }
    else
    {
        return c + Sum(c-1, d);
    }
    
}


Console.WriteLine($"{Sum(b, a)}");