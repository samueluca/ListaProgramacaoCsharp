using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[5];

        
        Console.WriteLine("Digite 5 numeros inteiros:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine("\nVetor na ordem inversa:");

        for (int i = 4; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");
        }

        
    }
}

