// показать 3 цифру трехзначного числа

int n = 128;

int third = (n%10);
Console.Write("последняя цифра ");
Console.WriteLine(third);

// показать 2 цифру трехзначного число
int second = ((n/10)%10);
Console.Write("вторая цифра ");
Console.WriteLine(second);

// показать 1 цифру трехзначного числа, 
//можно не искать отаток от деления %10, если число трехзначное n/100
int first = ((n/100)%10);
Console.Write("первая цифра ");
Console.WriteLine(firs);