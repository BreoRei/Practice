// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] NewArray(int[,] arr)
{
    int[,] arrA = arr;
    int[] ar = new int[arrA.GetLength(1)];
    int i = 0;
    if (i == 0)
    {
        for (int j = 0; j < arrA.GetLength(1); j++)
        {
            ar[i] = arrA[arrA.GetLength(0) - 1, j];
            arrA[arrA.GetLength(0) - 1, j] = arrA[i, j];
            arrA[i, j] = ar[i];
        }

    }
    return arrA;
}


int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[,] FillingAnArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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

Console.Write("Введите количество строк: ");
int line = UserInput();
Console.Write("Введите количество столбцов: ");
int column = UserInput();

int[,] array = FillingAnArray(line, column);
PrintArray(array);
Console.WriteLine();
int[,] newArray = NewArray(array);
PrintArray(newArray);

