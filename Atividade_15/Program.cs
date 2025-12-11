using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        int n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(
            "Digite um número inteiro positivo:", "Entrada de Dados"));

        bool primo = true;

        if (n < 2)
        {
            primo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    primo = false;
                    break;
                }
            }
        }

        MessageBox.Show(
            $"O número {n} é primo? {primo}",
            "Resultado"
        );
    }
}
