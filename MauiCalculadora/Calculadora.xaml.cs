namespace MauiCalculadora;

public partial class Calculadora : ContentPage
{
	public Calculadora()
	{
		InitializeComponent();
	}

    private void btn05_Clicked(object sender, EventArgs e)
    {
		lblPainel.Text += "5";
    }
}