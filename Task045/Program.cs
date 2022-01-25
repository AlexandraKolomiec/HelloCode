int [] array = new int [8];
int k = 1;
int n = 2; // тк 1 и 2 цифра единицы, начинаем с индекса 2
array[0] = k;
array[1] = k;
Console.WriteLine (k);
Console.WriteLine (k);
while (n <= 7)
{
    array[n] = (array[n - 1] + array[n - 2]); 
    Console.WriteLine(array[n]);
    n++;
}

// Показать числа Фибоначчи

//Console.Clear();


//double Fibonacci(int n)
{
    //if(n == 1 || n == 2) return 1;
    //else return Fibonacci(n-1) + Fibonacci(n-2);
}

//for (int i = 1; i <= 10; i++)
{
    //Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

