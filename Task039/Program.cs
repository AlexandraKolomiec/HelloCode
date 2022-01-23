// произведение пар чисел в одномерном массива. Пара 1 и последний, 2 и предпоследний итд

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,25);
    Console.WriteLine(array[i]);
}
Console.WriteLine();
 
for (int i = 0; i < array.Length; i++)
{
    int Multiply = array[i] * array[(array.Length - i - 1)];
    Console.WriteLine (Multiply);
    if (i >= array.Length / 2 -1) break;
}




     
 