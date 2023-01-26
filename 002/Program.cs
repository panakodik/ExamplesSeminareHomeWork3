// Подсчитать сумму цифр в числе
Console.Clear();
Console.WriteLine("Подсчитать сумму цифр в числе");
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int sum = 0;

while (N > 0)
{
    int n = N % 10;
    sum = sum + n;
    N = N / 10;
}

Console.WriteLine("Сумма цифр в числе = " + sum);