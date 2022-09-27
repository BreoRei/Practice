// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 6, 7, 8"

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void Integers(int i, int j)
{
    if (j != i)
    {
        Integers(i, j - 1);
    }
    PrintTextToString($"{j} ");
}

Console.Clear();
PrintTextToString("Введите число: ");
int m = UserInput();
PrintTextToString("Введите число: ");
int n = UserInput();

Console.Clear();
PrintTextToString($"M = {m}; N = {n}-> ");
Integers(m, n);