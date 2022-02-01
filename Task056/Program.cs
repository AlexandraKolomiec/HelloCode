// программа обмена элементов первой и последней строки
int[,] matrix = new int[4, 4];

void PrintFillArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 12);
      Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}
PrintFillArray(matrix);
Console.WriteLine();

int row = matrix.GetLength(0);
for (int i = 0; i < matrix.GetLength(1); i++)
{
   int temp = matrix[0, i];
   matrix[0,i] = matrix[row -1, i];
   matrix[row -1, i] = temp;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine();
}
