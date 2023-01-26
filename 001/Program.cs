// Найти кубы чисел от 1 до N
Console.WriteLine("Найти кубы чисел от 1 до N");
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Квадрат числа " + i + " равен: " + i * i * i);
}
Console.WriteLine("Получили возведение в квадрат чисел от 1 до " + n);