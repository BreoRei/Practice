Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string str = ($"{num} ->");
for (int i = 1; i <= num; i++)
{
    double sq = Math.Pow(i, 2);
    str += ($"{sq}, ");
}
Console.WriteLine(str);

// Console.Clear();
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= num; i++){
//     double sq = Math.Pow(i, 2);
//     Console.WriteLine($"{i}^2 = {sq}");
// }