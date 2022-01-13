// Возвести число А в степень В при помощи цикла

Console.Clear();
Console.Write("Введите число, которое нужно вознести в степень: "); 
double chislo = Convert.ToDouble(Console.ReadLine());
double vozvedenie = 1;
Console.Write("Введите степень: ");
int stepen = Convert.ToInt32(Console.ReadLine()); 
for (int i = 0; i < stepen; i++)
 {    
     vozvedenie *= chislo;
 } 
Console.Write("Ответ: ");
Console.Write(vozvedenie);