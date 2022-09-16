// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника:**каждая сторона треугольника меньше суммы двух других сторон.

void PrintTextToString(String text)
{
    Console.Write(text);
}

void PrintTextWithLineBreak(String text)
{
    Console.WriteLine(text);
}

Console.Clear();
PrintTextWithLineBreak("Введите три числа.");
PrintTextToString("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
PrintTextToString("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
PrintTextToString("Введите число C: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A <= B + C && B <= A + C && A + B >= C) PrintTextWithLineBreak("Это треугольник");
else PrintTextWithLineBreak("Это не треугольник");