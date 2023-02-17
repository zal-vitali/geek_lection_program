
double Fibonacci(int n, int q)
{
    q++;
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1, q) + Fibonacci(n - 2, q);
}

int q = 0;

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i,q)}");
}

