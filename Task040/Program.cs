// в массиве вещественных чисел найти разницу между min max эл-тами

//ouble [] array = new double[10];
//for (double i = 1; i < array.Length; i++)
{
  //array[i] = new Random.NextDouble(); //* 10 + 10; // диапазон[10,20]
  //Console.WriteLine(array[i]);
}
//double max = array[0];
//double min = array[0];
//for (int i = 0; i < Array.Length; i++)
{
  //if (array[i] = max)
    {
     //Console.WriteLine(max);
    }
 
  //else if (array[i] = min)
    {
      //Console.WriteLine(min);  
    }
    
  //else (i++);
}  

//Console.WriteLine(max - min);

// в массиве вещественных чисел найти разницу между min max эл-тами
double[] Array = { 4, 27, 18, 10, 12, 14, 16, };

double MaxNumber(double[] Array)
{
  double max = Array[0];
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] > max) max = Array[i];
  }
  return max;
}

double MinNumber(double[] Array)
{
  double min = Array[0];
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] < min) min = Array[i];
  }
  return min;
}

double a = MaxNumber(Array); 
System.Console.WriteLine(a);
double b = MinNumber(Array); 
System.Console.WriteLine(b);
System.Console.WriteLine(a-b);

