// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void PrintTextToString(String text)
{
    Console.Write(text);
}

void Fibonaссi(int num)
{
    int fib1 = 0;
    int fib2 = 1;
    Console.Write($"{fib1} {fib2} ");
    int help = 0;
    for (int i = 2; i < num; i++)
    {
        help = fib2;
        fib2 = fib1 + fib2;
        fib1 = help;
        Console.Write($"{fib2} ");
    }
}

PrintTextToString("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintTextToString($"Если N = {number} -> ");
Fibonaссi(number);