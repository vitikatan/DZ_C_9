Console.Clear();

Console.WriteLine($"Введите число N:");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите число M:");
int M = int.Parse(Console.ReadLine());

int Factorial(int n)
{
    if (n == M) return M;
    else return n + Factorial(n - 1);
}

Console.WriteLine(Factorial(N));

