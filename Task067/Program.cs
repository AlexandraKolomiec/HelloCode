// Рекурсия, показать натуральные числа от N до 1, N задано

void PrintN(int n)// метод который будет вызывать сам себя
{
    Console.Write($"{n} ");
    if (n != 1)
        PrintN(n - 1);
}

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
PrintN(N);

