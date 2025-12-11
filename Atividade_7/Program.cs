using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int[10];
        int soma = 0;

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
            soma += vetor[i];
        }

        double media = soma / 10.0;

        int acimaDaMedia = 0;
        for (int i = 0; i < 10; i++)
        {
            if (vetor[i] > media)
            {
                acimaDaMedia++;
            }
        }

        Console.WriteLine($"\nMédia dos valores: {media}");
        Console.WriteLine($"Quantidade de elementos acima da média: {acimaDaMedia}");
    }
}
