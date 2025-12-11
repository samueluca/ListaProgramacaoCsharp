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
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        int somaPrincipal = 0;
        int somaSecundaria = 0;

        int N = 4;

        for (int i = 0; i < N; i++)
        {
            somaPrincipal += matriz[i, i];
            somaSecundaria += matriz[i, N - 1 - i];
        }

        MessageBox.Show(
            "Soma da Diagonal Principal: " + somaPrincipal +
            "\nSoma da Diagonal Secundária: " + somaSecundaria,
            "Resultado"
        );
    }
}
