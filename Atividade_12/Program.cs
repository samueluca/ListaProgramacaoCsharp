using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        int[,] matriz = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        int linha = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(
            "Digite o índice da linha (0, 1 ou 2):", "Entrada de Dados"));

        int soma = 0;
        for (int j = 0; j < 4; j++)
        {
            soma += matriz[linha, j];
        }

        MessageBox.Show(
            $"A soma dos elementos da linha {linha} é {soma}.",
            "Resultado"
        );
    }
}
