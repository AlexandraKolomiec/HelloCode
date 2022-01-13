// таблица квадратов чисел от 1 до n
int n = 10;
for (int i = 1; i < n; i++)
{
   Console.WriteLine($"{i} | {Math.Pow(i , 2)}"); 
   Console.WriteLine("___", "___");
}
