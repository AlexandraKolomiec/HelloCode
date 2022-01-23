// являются ли 3 числа сторонами треугольника

int ab = 20;
int bc = 4;
int ca = 4;

if (((ab + bc) > ca) && ((bc + ca) > ab) && ((ca + ab) > bc))
{
    Console.WriteLine(" это стороны треугольника");
}
else
{
    Console.WriteLine("числа не являются сторонами треугольника");
}

// 41. Выяснить являются ли три числа сторонами треугольника
//Console.Clear();
//Console.Write("Введите строну а: ");
//double num1 = double.Parse(Console.ReadLine());
//Console.Write("Введите строну b: ");
//double num2 = double.Parse(Console.ReadLine());
//Console.Write("Введите строну c: ");
//double num3 = double.Parse(Console.ReadLine());
//if ((num1 + num2 > num3) && (num2 + num3 > num1) && (num1 + num3 > num2))
{
//Console.WriteLine("Числа являются сторонами треугольника");
}
//else
{
//Console.WriteLine("Числа не являются сторонами треугольника");
}
