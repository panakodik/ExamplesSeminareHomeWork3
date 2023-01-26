// Написать программу вычисления произведения чисел от 1 до N
Console.Clear();
Console.WriteLine("Программа вычисления произведения чисел от 1 до N");
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
int pow = 1;
for (int i = 1; i <= n; i++)
{
    pow = pow * i;
}
Console.WriteLine("Получили произведения чисел от 1 до " + n + " равно " + pow);
