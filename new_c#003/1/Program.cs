int qest = 0;

while (qest == 0)
{
    Console.WriteLine("Введите кординаты X ");
    int x = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Введите кординаты Y ");
    int y = Convert.ToInt16(Console.ReadLine());

    if (x != 0 && y != 0)
    {
        if (x > 0)
        {
            if (y > 0) Console.WriteLine("Первая");
            else Console.WriteLine("Четвертая");
        }
        else
        {
            if (y > 0) Console.WriteLine("Вторая");
            else Console.WriteLine("Третья");
        }
    }
    Console.WriteLine("Если хотите проверить  еще одну точку введите 0  ");
    qest = Convert.ToInt16(Console.ReadLine());
}
