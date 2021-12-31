// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("введите номер четверти от 1 до 4");
string quarter = Console.ReadLine();
if (quarter == "1")
{
    Console.Write(" диапазоны возможных координат в пределах:");
    Console.WriteLine(" x > 0 , y > 0");
}
if (quarter == "2")
{
    Console.Write(" диапазоны возможных координат в пределах:");
    Console.WriteLine(" x < 0 , y > 0");
}
if (quarter == "3")
{
    Console.Write(" диапазоны возможных координат в пределах:");
    Console.WriteLine(" x < 0 , y < 0");
}
if (quarter == "4")
{
    Console.Write(" диапазоны возможных координат в пределах:");
    Console.WriteLine(" x > 0 , y < 0");
}