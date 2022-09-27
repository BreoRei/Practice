// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

void Integers(int num)
{
    if (num != 1)
    {
        Integers(num - 1);
    }
    PrintTextToString($"{num} ");
}

Console.Clear();
PrintTextToString("Введите число: ");
int number = UserInput();
Console.Clear();
PrintTextToString($"N = {number} -> ");
Integers(number);