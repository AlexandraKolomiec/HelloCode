// Возвести число А в степень В при помощи цикла

//Console.Clear();
//Console.Write("Введите число, которое нужно вознести в степень: "); 
//double chislo = Convert.ToDouble(Console.ReadLine());
//double vozvedenie = 1;
//Console.Write("Введите степень: ");
//int stepen = Convert.ToInt32(Console.ReadLine()); 
//for (int i = 0; i < stepen; i++)
 {    
  //   vozvedenie *= chislo;
 } 
//Console.Write("Ответ: ");
//Console.Write(vozvedenie);

int degree(int A, int B)
 {  
    int count = 1;  
    int degree = 1; 
    while (count <= B)  
    {   degree = degree*A;  
        count++;   
    }    
    return degree;
 } 
Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень возвести?");
int B = Convert.ToInt32(Console.ReadLine());
int N = degree(A, B);
Console.WriteLine(N);
