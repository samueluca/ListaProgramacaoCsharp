using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        double saldo = 1000.0;
        int opcao = 0;

        while (opcao != 4)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Escolha uma opção:\n" +
                "1. Sacar\n" +
                "2. Depositar\n" +
                "3. Consultar Saldo\n" +
                "4. Sair",
                "Caixa Eletrônico"
            );

            if (!int.TryParse(input, out opcao))
            {
                MessageBox.Show("Opção inválida!", "Erro");
                continue;
            }

            switch (opcao)
            {
                case 1: // Sacar
                    double saque = double.Parse(Microsoft.VisualBasic.Interaction.InputBox(
                        "Digite o valor para saque:", "Saque"));

                    if (saque > saldo)
                        MessageBox.Show("Saldo insuficiente!", "Erro");
                    else
                    {
                        saldo -= saque;
                        MessageBox.Show($"Saque realizado! Novo saldo: R$ {saldo:F2}", "Saque");
                    }
                    break;

                case 2: // Depositar
                    double deposito = double.Parse(Microsoft.VisualBasic.Interaction.InputBox(
                        "Digite o valor para depósito:", "Depósito"));
                    saldo += deposito;
                    MessageBox.Show($"Depósito realizado! Novo saldo: R$ {saldo:F2}", "Depósito");
                    break;

                case 3: // Consultar Saldo
                    MessageBox.Show($"Saldo atual: R$ {saldo:F2}", "Saldo");
                    break;

                case 4: // Sair
                    MessageBox.Show("Saindo do sistema.", "Caixa Eletrônico");
                    break;

                default:
                    MessageBox.Show("Opção inválida!", "Erro");
                    break;
            }
        }
    }
}
