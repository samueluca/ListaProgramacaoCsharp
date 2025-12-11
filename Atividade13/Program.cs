using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        int[,] original = new int[2, 3];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                original[i, j] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(
                    $"Digite o valor para a posição [{i},{j}] da matriz original:", "Entrada de Dados"));
            }
        }

        int[,] transposta = new int[3, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                transposta[j, i] = original[i, j];
            }
        }

        string msgOriginal = "Matriz Original:\n";
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                msgOriginal += original[i, j] + " ";
            }
            msgOriginal += "\n";
        }

        string msgTransposta = "Matriz Transposta:\n";
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                msgTransposta += transposta[i, j] + " ";
            }
            msgTransposta += "\n";
        }

        MessageBox.Show(msgOriginal + "\n" + msgTransposta, "Resultado");
    }
}
