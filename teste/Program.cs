using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o número de termos da sequência de Fibonacci que deseja:");
        int termos = int.Parse(Console.ReadLine());

        for (int i = 0; i < termos; i++)
        {
            Console.WriteLine($"{i + 1}º termo: {Fibonacci(i)}");
        }
    }

    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}