// в двумерном массиве показать позиции числа заданного пользователем или что такого элта нет
int[,] matrix = new int[5, 5];
Console.WriteLine("Введите число");
int user = Convert.ToInt32(Console.ReadLine());

void PrintFillArray(int[,] mat)
{
  for (int i = 0; i < mat.GetLength(0); i++)
  {
    for (int j = 0; j < mat.GetLength(1); j++)
    {
      mat[i, j] = new Random().Next(1, 10);
      System.Console.Write($"{mat[i, j]} ");
    }
    System.Console.WriteLine();
  }
}

//void ShowNumber(int[,] mat)
{
  //int AmountElements = 0;
  //for (int i = 0; i < mat.GetLength(0); i++)
  {
    //for (int j = 0; j < mat.GetLength(1); j++)
    {
      //if (mat[i, j] == user) System.Console.WriteLine($"row = {i}, column = {j}");
      //else// вывод одного ответа, а не на каждое значение
      {
        //AmountElements++;
      }
    }
  }
  //if (AmountElements == matrix.Length)
  //Console.WriteLine("Такого элемента нет");
}

PrintFillArray(matrix);
ShowNumber(matrix);


//вывод одного отрицательно ответа, через bool
void ShowNumber(int[,] mat)
{
    bool non = false;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] == user)
            {
                System.Console.WriteLine($"row = {i}, column = {j}");
                non = true;
            }
        }
    }
    if (non == false)
        Console.WriteLine("Такого элемента нет");
}



// Создание двумерного массива
//void CreatMatrix (int [,] matrix)
{
    //for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //for (int j = 0; j < matrix.GetLength(1); j++)
        {
           // matrix[i, j] = new Random().Next(-10, 10);
        }
    }
}

// Вывод двумерного массива
//void PrintMatrix (int [,] matrix)
{
    //for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i, j]} ");
        }
        //Console.WriteLine();
    }
    //Console.WriteLine();
}

// Вывод позиций чисел
//void PrintPositions (int [,] matrix, int N)
{
    //int AmountElements = 0;
    //for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //if (matrix[i, j] == N)
            {
                //Console.WriteLine($"{i}, {j}");
            }
            //else
            {
                //AmountElements++;
            }
        }
    }
    //if (AmountElements == matrix.Length)
        //Console.WriteLine("Такого элемента нет");
}

//Console.WriteLine("Введите число строк двумерного массива");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число столбцов двумерного массива");
//int k = Convert.ToInt32(Console.ReadLine());
//int [,] matrix = new int [n, k];
//CreatMatrix (matrix);
//PrintMatrix (matrix);
//Console.WriteLine("Введите число, я выведу его позиции");
//int N = Convert.ToInt32(Console.ReadLine());
//PrintPositions (matrix, N);
