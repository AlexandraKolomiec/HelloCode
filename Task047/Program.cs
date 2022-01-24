// копирование массива

int [] array = new int [6] {8, -3, 16, -6, -1, 0}; 
int[] copy = new int [6];

for(int i = 0; i < 6; i++)
{
    copy[i] = array[i];
    Console.WriteLine (copy[i]);
}
