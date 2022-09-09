// ** Вводим с клавы число х - целое, а затем вводим х разных целых чисел. 
// Нужно вывести на экран самое большое и второе по величине число из введенных.

// Вариант 1
Console.Write("Введите количество чисел: ");
int numLength = Convert.ToInt32(Console.ReadLine());

int max = 0;
int max2 = 0;

for (int i = 0; i < numLength; i++)
{
    Console.WriteLine($"Введите {i + 1} число ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > max)
    {
        max2 = max;
        max = number;
    }
}
Console.WriteLine($"Первое по велечине - {max}, второе по велечине - {max2}");

// Вариант 2

int[] numbers = new int[numLength];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите {i + 1} число ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max2 = max;
        max = numbers[i];
    }
}
string answer = "Из массива: ";
for (int i = 0; i < numbers.Length; i++)
{
    answer += ($"{numbers[i]}, ");
}
answer += ($"самое большое число = {max}, второе по велечине - {max2}.");
Console.WriteLine(answer);







