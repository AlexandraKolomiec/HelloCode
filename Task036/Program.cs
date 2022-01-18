// задать массив с + 3-значными числами, показать кол-во четных и нечетных
int [] array = new int [6];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000); 
    Console.WriteLine(array[i]);
}
Console.WriteLine();

int Find2Array (int[] array)
{
    int A = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0) A++;
    }
    return A;
}

int A = Find2Array (array);
int B = array.Length - A;
Console.WriteLine($"В массиве {A} четных чисел, {B} нечетных чисел");
