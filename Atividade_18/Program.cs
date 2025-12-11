using System;
using System.Windows.Forms;

class Animal
{
    public string Nome { get; set; }

    public virtual void EmitirSom()
    {
        // Método genérico
    }
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        MessageBox.Show("Latindo...", Nome);
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        MessageBox.Show("Miando...", Nome);
    }
}

class Program
{
    [STAThread]
    static void Main()
    {
        Cachorro cachorro = new Cachorro();
        cachorro.Nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cachorro:", "Entrada de Dados");
        cachorro.EmitirSom();

        Gato gato = new Gato();
        gato.Nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do gato:", "Entrada de Dados");
        gato.EmitirSom();
    }
}
