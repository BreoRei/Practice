// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int Integers(int i, int j, int s)
{
    if (j != 1)
    {
        s *= i;
        return Integers(i, j - 1, s);
    }
    return s;
}

Console.Clear();
PrintTextToString("Введите число: ");
int a = UserInput();
PrintTextToString("Введите число: ");
int b = UserInput();
int sum = a;
Console.Clear();
PrintTextToString($"A = {a}; N = {b}-> {Integers(a, b, sum)}");
