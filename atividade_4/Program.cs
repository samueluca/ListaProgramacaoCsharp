using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Variáveis para armazenar as notas e a média
        int numero;


        // 1. ENTRADA DE DADOS (usando Console.ReadLine e conversão)
        Console.WriteLine("--- Descruba o fatorial (CLI) ---");

        // Leitura do numero
        Console.Write("Digite um numero inteiro positivo: ");

        // Tenta converter a string lida para double. Se for inválido, o programa irá

        numero = int.Parse(Console.ReadLine());

        // 2. PROCESSAMENTO (Cálculo para calcular fatorial)

        long fatorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine("\n--- Resultado ---");


        Console.WriteLine("O fatorial de " + numero + " é : " + fatorial);




        //formata para 2 casas decimais

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar o

    }
}
