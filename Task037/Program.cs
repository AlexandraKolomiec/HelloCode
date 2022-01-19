// в одномерном массиве из 123 чисел нати кол-во эл-тов из отрезка [10, 99]
int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);

}
//Console.WriteLine(array[99] - array[10]);
Console.WriteLine((array.Length - 24) - (array.Length - 113)); // 123-99=24, 123-10=113
    