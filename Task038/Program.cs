// сумма чисел одномерного массива стояших на нечетной позиции
int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,20);
    Console.WriteLine(array[i]);
}
Console.WriteLine();

int SumOddPositionArray (int [] array)
{
    int SumOddPosition = 0;
    for (int i = 0; i < array.Length; i++)
    {
        //if (array [i] % 2 == 1) SumOddPosition = SumOddPosition + array [i]; сумма нечетных значений
        if (i % 2 == 1) SumOddPosition = SumOddPosition + array [i];
    }
    return SumOddPosition;
}

int N = SumOddPositionArray (array);
Console.WriteLine($" Сумма элементов стоящих на нечетной позиции равна {N}");