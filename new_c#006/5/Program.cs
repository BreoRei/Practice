// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью 
// поэлементного копирования.

void ArrayNew(int[] arr, int[] arr1)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr1[i] = arr[i];
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void PrintTextWithLineBreak(String text)
{
    Console.WriteLine(text);
}
Console.Clear();
int[] array = { 1, 2, 3, 5, 7, 9, 2, 6 };
int[] arrayNew = new int[array.Length];
PrintTextWithLineBreak("Заданный массив: ");
PrintArray(array);
ArrayNew(array, arrayNew);
PrintTextWithLineBreak("");
PrintTextWithLineBreak("Копия массива: ");
PrintArray(arrayNew);
