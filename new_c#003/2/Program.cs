//  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти  ");
int count = Convert.ToInt32(Console.ReadLine());

if (count > 4 || count < 1)
{
    Console.WriteLine("Введите число от 1 до 4");
}
else
{
    if (count == 1) Console.WriteLine("Х от 0 до ∞, Y от 0 до ∞");
    if (count == 2) Console.WriteLine("Х от 0 до -∞, Y от 0 до ∞");
    if (count == 3) Console.WriteLine("Х от 0 до -∞, Y от 0 до -∞");
    if (count == 4) Console.WriteLine("Х от 0 до ∞, Y от 0 до -∞");
}

