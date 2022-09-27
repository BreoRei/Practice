// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.



void PrintTextToString(string text)
{
    Console.Write(text);
}

int UserInput()
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int[,] FillArray(int m, int n)
{
    int[,] arr = new int[m, n];
    int vertex = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int count = vertex;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (count > 0)
            {
                if (j == 0 || j == vertex - 1)
                {
                    arr[i, j] = 1;
                    count--;
                }
                else
                {
                    arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
                    count--;
                }
            }
            else break;
        }
        vertex++;
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0)
            {
                for (int k = 0; k + i < arr.GetLength(1); k++)
                {
                    PrintTextToString(" ");
                }
                Console.Write($"{arr[i, j]} ");
            }
            else if (arr[i, j] > 0)
                Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintTextToString("Введите количество строк: ");
int line = UserInput();
int column = line;
int[,] array = FillArray(line, column);
Console.Clear();
PrintArray(array);



