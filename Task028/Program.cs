// сумма цифр в числе
//Console.Clear();
//Console.Write("Введите число: ");
//int number=int.Parse(Console.ReadLine());
//int i=0;
//while(number>0) 
{
  // i = i + number % 10;
  // number /= 10;
}
//Console.WriteLine("Сумма числа: {0}", i);
//return 0;

int SumNumbers (int A)
{
    int sum = 0;
    while (A > 0)
    {
        int B = A % 10;
        A = A/10;
        sum = sum + B;
    }
    return sum;
}

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int N = SumNumbers (A);
Console.WriteLine($"В числе {A} сумма цифр равна {N}");
