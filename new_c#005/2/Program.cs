// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void arr()
{
    int[] array = new int[12];
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-9, 10);
        Console.Write($"{array[index]}, ");
    }
    Console.WriteLine();
    int[] arr = array;
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] *= -1;
        Console.Write($"{arr[index]}, ");
    }
}
arr();