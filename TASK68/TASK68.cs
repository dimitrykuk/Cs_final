// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

bool flag = false;
while (flag == false)
{
    Console.WriteLine("Введите m =");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n =");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < 0 || n < 0) Console.WriteLine("\n\x1b[4mВведено по крайней мере 1 отрицательное число\x1b[1m\n" + "Необходимо ввести неотрицательные числа m и n!\n" + "Повторите попытку!\n\x1b[0m");
    else
    {
        flag = true;
        int k = Ackerman(m,n);
        Console.WriteLine("\n"+k);
    }
}

int Ackerman(int n, int m){ 
    if (n != 0 &&  m != 0){
        return Ackerman(n - 1, Ackerman(n, m-1));
    }
    else if (m == 0) {
       return Ackerman(n-1, 1);//
    }
    return m+1;
}
