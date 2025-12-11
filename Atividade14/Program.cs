using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        double peso = double.Parse(Microsoft.VisualBasic.Interaction.InputBox(
            "Digite seu peso em kg:", "Entrada de Dados"));

        double altura = double.Parse(Microsoft.VisualBasic.Interaction.InputBox(
            "Digite sua altura em metros:", "Entrada de Dados"));

        double imc = peso / (altura * altura);

        string classificacao;

        if (imc < 18.5)
            classificacao = "Abaixo do peso";
        else if (imc < 25)
            classificacao = "Peso normal";
        else if (imc < 30)
            classificacao = "Sobrepeso";
        else
            classificacao = "Obesidade";

        MessageBox.Show(
            $"Seu IMC é {imc:F2}.\nClassificação: {classificacao}.",
            "Resultado"
        );
    }
}
