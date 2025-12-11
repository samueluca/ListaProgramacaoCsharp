using System;

class Program
{
    static void Main(string[] args)
    {
        int[] VetorA = { 1, 3, 5, 7, 9 };
        int[] VetorB = { 2, 4, 6, 8, 10 };
        int[] VetorC = new int[10];

        int pos = 0;

        for (int i = 0; i < 5; i++)
        {
            VetorC[pos++] = VetorA[i];
            VetorC[pos++] = VetorB[i];
        }

        Console.WriteLine("VetorC preenchido:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(VetorC[i] + " ");
        }
    }
}
