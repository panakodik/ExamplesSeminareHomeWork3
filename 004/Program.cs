// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру в интервале от 1 до N");
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
{
    int a = i * i * i;
    if(a % 2 == 0)
    {
        Console.WriteLine("Куб числа " + i + " равен " + a + " - заканчивается на четкую цифру ");
    }
}
