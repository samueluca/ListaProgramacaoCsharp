using System;
using System.Windows.Forms;

class Animal
{
    public string Nome { get; set; }

    public virtual void EmitirSom()
    {
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
        Animal[] animais = new Animal[2];

        Cachorro cachorro = new Cachorro();
        cachorro.Nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do cachorro:", "Entrada de Dados");
        animais[0] = cachorro;

        Gato gato = new Gato();
        gato.Nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do gato:", "Entrada de Dados");
        animais[1] = gato;

        foreach (Animal animal in animais)
        {
            animal.EmitirSom();
        }
    }
}
