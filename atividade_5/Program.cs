using System;

class Program
{
    static void Main(string[] args)
    {
        int N;

        Console.Write("Digite um valor para N: ");
        N = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        Console.Write("Sequência de Fibonacci: ");

        for (int i = 0; i < N; i++)
        {
            Console.Write(a + " ");
            int c = a + b;
            a = b;
            b = c;
        }
    }
}
