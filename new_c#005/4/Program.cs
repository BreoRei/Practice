// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 


void arr()
{
    int[] array = new int[123];
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-100, 101);
        // Console.Write($"{array[index]}, ");
    }
    Console.WriteLine($"В заданном массиве из 123 чисел.");
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 10 && 99 > array[index])
        {
            count++;
        }
    }
    Console.Write($"Количество чисел в отрезке [10,99] = {count}");
}
arr();