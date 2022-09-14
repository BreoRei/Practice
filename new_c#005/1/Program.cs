// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

void arr()
{
    int[] array = new int[12];
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-9, 10);
        Console.Write($"{array[index]}, ");
    }

    int sum1 = 0;
    int sum2 = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0)
        {
            sum1 += array[index];
        }
        else
        {
            sum2 += array[index];
        }
    }
    Console.WriteLine();
    Console.Write($"Cумма положительных {sum1}, сумма отрецательных {sum2} ");
}

arr();