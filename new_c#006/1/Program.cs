// Задача 39 Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void ArrayСreation(int[] arr)
{
    Console.Write("Введите диапазон массива.\nМинимальное значание массива: ");
    int minArray = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное значание массива: ");
    int maxArray = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minArray, maxArray);
        // Console.Write($"{array[index]} ");
    }
}

void FlipArray(int[] arr)
{
    int help = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        help = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = help;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void PrintTextToString(String text)
{
    Console.Write(text);
}

void PrintTextWithLineBreak(String text)
{
    Console.WriteLine(text);
}


Console.Clear();

PrintTextToString("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

ArrayСreation(array);
PrintTextToString("Массив один: ");
PrintArray(array);
PrintTextWithLineBreak("");
FlipArray(array);
PrintTextToString("Массив  два: ");
PrintArray(array);

