// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты. Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[,] FillingAnArray(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}

int[,] ReplacingEvenIndicesWithTheSquareOfANumber(int[,] arr)
{
    int[,] arrA = arr;
    for (int i = 2; i < arrA.GetLength(0); i += 2)
    {
        for (int j = 2; j < arrA.GetLength(1); j += 2)
        {
            arrA[i, j] *= arrA[i, j];
        }
    }
    return arrA;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintTextToString("Введите количество строк: ");
int line = UserInput();
PrintTextToString("Введите количество столбцов: ");
int column = UserInput();
PrintTextToString("Введите начальное значение массива: ");
int first = UserInput();
PrintTextToString("Введите конечное значение массива: ");
int second = UserInput();
Console.Clear();
int[,] array = FillingAnArray(line, column, first, second);
PrintArray(array);
Console.WriteLine();
int[,] arrayA = ReplacingEvenIndicesWithTheSquareOfANumber(array);
PrintArray(arrayA);