// Определить сколько чисел больше 0 введено с клавиатуры
int i = 0;
int count = 0;
while (i < 5)
{
    Console.WriteLine("введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    if(a > 0)
    {
        count = count + 1; 
    }
    i++;
}
Console.WriteLine($"количество чисел больше 0 = {count}");

