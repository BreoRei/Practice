// Задача 33: Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// - 3; массив[6, 7, 19, 345, 3]->да


int[] array = new int[50];
for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(-20, 20);
    // Console.Write($"{array[index]}, ");
}
Console.WriteLine("Введите число от -20 до 20 для поиска в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int index = 0; index < array.Length; index++)
{
    if (number == array[index])
    {
        Console.Write($"число {number} есть в данном массиве!");
        return;
    }

}
Console.Write($"число {number} нет в данном массиве!");