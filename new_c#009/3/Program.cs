// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}


int Integers(int i, int sum)
{
    if (i != 0)
    {
        sum += (i % 10);
        return Integers(i / 10, sum);
    }
    return sum;
}
Console.Clear();
PrintTextToString("Введите число: ");
int m = UserInput();
Console.Clear();
int sum = 0;
PrintTextToString($"Сумма числа {m} -> {Integers(m, sum)} ");


