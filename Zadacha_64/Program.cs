Console.Clear();

Console.WriteLine($"Введите число N:");
int N = int.Parse(Console.ReadLine());

int Factorial(int n)
{
    if (n == 1) return 1;
    else return n - 1;
}


for (int i = N; i > 1; i = i - 1)
{
    Console.WriteLine(Factorial(i));
}

