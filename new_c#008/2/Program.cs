// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[,] ReplacingRowsColumn(int[,] arr)
{
    int[,] arrA = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrA.GetLength(1); j++)
        {
            arrA[j, i] = arr[i, j];
        }
    }
    return arrA;
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
int[,] newArray = ReplacingRowsColumn(array);
PrintArray(newArray);