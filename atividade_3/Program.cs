using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Variáveis para armazenar as notas e a média
        double c, f ;
        Boolean par = true;


        // 1. ENTRADA DE DADOS (usando Console.ReadLine e conversão)
        Console.WriteLine("--- Descruba se é impar ou par (CLI) ---");

        // Leitura do numero
        Console.Write("Digite á temperatura em Celsius (°C): ");

        // Tenta converter a string lida para double. Se for inválido, o programa irá

        c = double.Parse(Console.ReadLine());

        // 2. PROCESSAMENTO (Cálculo para tranformar valor em Fahrenheit)
        
        f = c  * 1.8 + 32;

        Console.WriteLine("\n--- Resultado ---");

    
        Console.WriteLine("O valor em Fahrenheit (°F):  " + f);
        
        


        //formata para 2 casas decimais

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey(); // Espera o usuário pressionar uma tecla antes de fechar o

    }
}
