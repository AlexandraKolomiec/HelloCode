// задать массив из 12 чисел [-9, 9], найти сумму + и - чисел
int [] array = new int [12];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10); // 10 тк до 9 включительно
    Console.WriteLine(array[i]);
}
Console.WriteLine();

int SumPositivArray (int [] array)
{
    int SumPositiv = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) SumPositiv = SumPositiv + array [i];
        }
    return SumPositiv;
}

int SumNegativArray (int [] array)
{
    int SumNegativ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) SumNegativ = SumNegativ + array [i];
        }
    return SumNegativ;
}

int P = SumPositivArray (array);
int N = SumNegativArray (array);
Console.WriteLine($"Сумма положительных элементов = {P}");
Console.WriteLine($"Сумма отрицательных элементов = {N}");