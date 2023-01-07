Console.Clear();

Console.WriteLine($"Введите число M:");
uint M = uint.Parse(Console.ReadLine());

Console.WriteLine($"Введите число N:");
uint N = uint.Parse(Console.ReadLine());

static uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

Console.WriteLine(A(M,N));