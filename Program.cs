//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
if (M < 0)
{
    M = 1;
}
while (M < N)
{
    Console.Write(M + ", "); M++;
}
Console.Write(N);


//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (M < 0)
{
    M = 1;
}
while (M <= N)
{
    sum = sum + M; M++;
}
Console.WriteLine(sum);


//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int res = A(m, n);
Console.WriteLine(res);
int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}