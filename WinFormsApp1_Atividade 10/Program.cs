using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        // Criar a matriz 3x5
        int[,] matriz = new int[3, 5];

        // Preencher a matriz com valores informados pelo usuário
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Digite o valor para a posição [{i},{j}]:",
                    "Entrada de Dados"
                );

                // Tenta converter o valor para inteiro
                if (!int.TryParse(input, out matriz[i, j]))
                {
                    MessageBox.Show("Valor inválido! Será considerado 0.", "Erro");
                    matriz[i, j] = 0;
                }
            }
        }

        // Inicializar variáveis para encontrar o maior valor
        int maior = matriz[0, 0];
        int linhaMaior = 0;
        int colunaMaior = 0;

        // Percorrer a matriz para encontrar o maior valor
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                    linhaMaior = i;
                    colunaMaior = j;
                }
            }
        }

        // Exibir o resultado usando MessageBox
        MessageBox.Show(
            $"O maior valor da matriz é {maior}.\n" +
            $"Ele está na linha {linhaMaior} e coluna {colunaMaior}.",
            "Resultado"
        );
    }
}
00