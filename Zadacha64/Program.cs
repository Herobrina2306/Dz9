// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> " 4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();

Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine() ?? string.Empty);


int c = 0;
if (a % 2 ==1)
{
    
    c = a-1;
}
else
{
    c=a;
}
Console.Write($"N = {a} -> {Parity(c)}");

string Parity(int b)
{
    if (b == 2) return "2";
    else
    {
        return b + ", " + Parity(b-2);
    }
    
}



