using System;
using System.Windows.Forms;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public double CalcularValorTotalEmEstoque()
    {
        return Preco * QuantidadeEmEstoque;
    }
}

class Program
{
    [STAThread]
    static void Main()
    {
        Produto produto = new Produto();

        produto.Nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do produto:", "Entrada de Dados");
        produto.Preco = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite o preço do produto:", "Entrada de Dados"));
        produto.QuantidadeEmEstoque = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite a quantidade em estoque:", "Entrada de Dados"));

        double valorTotal = produto.CalcularValorTotalEmEstoque();

        MessageBox.Show(
            $"Produto: {produto.Nome}\nValor total em estoque: R$ {valorTotal:F2}",
            "Resultado"
        );
    }
}
