using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        int[,] matriz = new int[4, 3];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(
                    $"Digite o valor para a posição [{i},{j}]:", "Entrada de Dados"));
            }
        }

        int positivos = 0, negativos = 0, zeros = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matriz[i, j] > 0)
                    positivos++;
                else if (matriz[i, j] < 0)
                    negativos++;
                else
                    zeros++;
            }
        }

        MessageBox.Show(
            $"Total de elementos positivos: {positivos}\n" +
            $"Total de elementos negativos: {negativos}\n" +
            $"Total de elementos iguais a zero: {zeros}",
            "Resultado"
        );
    }
}
