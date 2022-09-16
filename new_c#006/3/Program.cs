// Задача 42:Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void PrintTextToString(String text)
{
    Console.Write(text);
}

void PrintTextWithLineBreak(String text)
{
    Console.WriteLine(text);
}

void TranslationToBinary(int[] arr, int num)
{
    int count = 0;
    for (int i = 0; 0 < num; i++)
    {
        arr[arr.Length - 1 - i] = num % 2;
        num /= 2;
        count++;
    }
    for (int i = 0; i + (arr.Length - count) < arr.Length; i++)
    {
        Console.Write($"{arr[i + (arr.Length - count)]}");
    }
}
Console.Clear();
int[] array = new int[8];
PrintTextToString("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintTextToString($"Число {number} в двоичной системе: ");
TranslationToBinary(array, number);


