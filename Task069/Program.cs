// //найти сумму элементов М до N, M и N заданы

//Console.Clear();

//int M = new Random().Next(1, 5);
//int N = new Random().Next(6, 21);

//int SumNumbersRec(int startNumber, int lastNumber)
{
    //if (startNumber == lastNumber) return startNumber;
    //else return lastNumber += SumNumbersRec(startNumber, lastNumber - 1);
}

//Console.WriteLine($"Первое число последовательности чисел (M) = {M}.");
//Console.WriteLine($"Последнее число последовательности чисел (N) = {N}.");
//int sum = SumNumbersRec(M, N);
//Console.WriteLine($"Сумма элементов в последовательности = {sum}.");


int sum = 0;
int Sum(int m, int n)
{
    if(m <= n)
    {
        return m+Sum(m+1, n); 
    }
    return 0;
}
Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int n = Convert.ToInt32(Console.ReadLine());
Sum(m, n);
Console.WriteLine(Sum(m,n));
