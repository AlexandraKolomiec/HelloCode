// в матрице чисел найти сумму элементов главной диагонали
int[,] matrix = new int[6, 6];

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
PrintFillArray(matrix);
Console.WriteLine();

int SumOfDiagonal = 0;
for (int i = 0; i < matrix.GetLength(0); ++i)
{   
  SumOfDiagonal = SumOfDiagonal + matrix[i, i];
}
Console.WriteLine($"сумма элементов главной диагонали = {SumOfDiagonal} ");