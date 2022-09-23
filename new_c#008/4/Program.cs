// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void PrintTextToString(String text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[,] RemoveTheMinimumIntersection(int[,] arr, int[] arrA)
{
    int a = arrA[0];//число которое нужно удалить
    int b = arrA[1];//строка которую нужно удалить
    int c = arrA[2];//столбец который нужно удалить
    int[,] arrB = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

    int m = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i > b || i < b)
        {
            int n = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j > c || j < c)
                {
                    arrB[m, n] = arr[i, j];
                    n++;
                }
            }
            m++;
        }
    }
    return arrB;
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

int[] MinimumValue(int[,] arr)
{
    int[] arrA = new int[3];
    arrA[0] = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < arrA[0])
            {
                arrA[0] = arr[i, j];
                arrA[1] = i;
                arrA[2] = j;
            }
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
int[] help = MinimumValue(array);
PrintTextToString($"Найденное число = [{help[0]}] с координатами массива [строка,столбец] = [{help[1]},{help[2]}]");
Console.WriteLine();
int[,] newArray = RemoveTheMinimumIntersection(array, help);
PrintArray(newArray);