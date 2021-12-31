// расстояние между точками в 2D и 3D
int xA = 2;
int xB = 4;
int yA = 3;
int yB = 6;
int zA = 5;
int zB = 10;

Console.Write("расстояние между точками 2D= ");
Console.WriteLine(Math.Sqrt((Math.Pow(xB - xA , 2) +  Math.Pow(yB - yA , 2))));
//               корень квадратный ()                 число в степени (число, 2-степень)      
Console.Write("расстояние между точками 3D= ");
Console.WriteLine(Math.Sqrt((Math.Pow(xB - xA , 2) +  Math.Pow(yB - yA , 2) + Math.Pow(zB - zA , 2))));