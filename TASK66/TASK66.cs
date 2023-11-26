// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElement(int N, int M, int sum = 0)
{
    if (N != M)
    {
        sum = sum + SumElement(N + 1, M, sum);
    }
    return sum = sum + N;
}
bool flag = false;
while (flag == false)
{
    Console.WriteLine("Введите нижнюю границу интервала: N=");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите верхнюю границу интервала: M=");
    int M = Convert.ToInt32(Console.ReadLine());
    if (M < N) Console.WriteLine("\n\x1b[4mНижняя граница выше верхней!\x1b[1m\n" + "Повторите попытку!\n\x1b[0m");
    else
    {
        flag = true;
        Console.WriteLine(SumElement(N, M));
    }
}
