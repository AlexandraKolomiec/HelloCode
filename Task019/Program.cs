// номер четверти плоскости для точки с координатами
int x = 0;
int y = 0;
if (x > 0 && y > 0)
{
   Console.WriteLine(" 1 четверть"); 
}
else if (x < 0 && y > 0)
{
   Console.WriteLine(" 2 четверть"); 
}
else if (x < 0 && y < 0)
{
   Console.WriteLine(" 3 четверть"); 
}
else if (x > 0 && y < 0)
{
    Console.WriteLine(" 4 четверть"); 
}
else
{
    Console.WriteLine("ОШИБКА");
}