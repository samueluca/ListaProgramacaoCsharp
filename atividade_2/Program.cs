using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Variáveis para armazenar as notas e a média
        double numero;
        Boolean par = true;
        
        
        // 1. ENTRADA DE DADOS (usando Console.ReadLine e conversão)
        Console.WriteLine("--- Descruba se é impar ou par (CLI) ---");
        
        // Leitura do numero
        Console.Write("Digite um numero inteiro: ");
        
        // Tenta converter a string lida para double. Se for inválido, o programa irá
        
        numero = double.Parse(Console.ReadLine());
        
        // 2. PROCESSAMENTO (Cálculo para descobri se e impa ou par)
        par = numero % 2 == 0 ? true : false;

        Console.WriteLine("\n--- Resultado ---");

        if (par)
        {
            Console.WriteLine("par");
        }else
        {
            Console.WriteLine("impar");
        }

            
        //formata para 2 casas decimais
    
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar o
       
    }
}