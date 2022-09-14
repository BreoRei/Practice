// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21
Console.Write($"Введите длинну массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

void arr()
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-9, 10);
        Console.Write($"{array[index]}, ");
    }
    Console.WriteLine();
    int[] arr = array;
    if (array.Length % 2 == 0)
    {
        for (int index = 0; index < array.Length / 2; index++)
        {
            arr[index] *= array[array.Length - index - 1];
            Console.Write($"{arr[index]}, ");
        }
    }
    else
    {
        for (int index = 0; index < array.Length / 2; index++)
        {
            arr[index] *= array[array.Length - index - 1];
            Console.Write($"{arr[index]}, ");
        }
        Console.Write($"{array[array.Length / 2]}");
    }
}
arr();