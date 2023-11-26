// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
void DispNatur(int N, int i = 1){
    if (i != N) {
    DispNatur(N,i+1);
    }
    //Console.Write("{0}", disp.Remove(disp.Length-2));
    if (i != 1) Console.Write($"{i}, ");
    else Console.Write($"{i}");
    return;
}

DispNatur(N);