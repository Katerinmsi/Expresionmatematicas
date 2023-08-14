namespace Expresion_matematica;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void CalcularButton_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(NumeroAEntry.Text, out double a) &&
            double.TryParse(NumeroBEntry.Text, out double b))
        {
            double resultado = Math.Pow(a + b, 2) / 2;
            ResultadoLabel.Text = "El resultado de la expresión es: " + resultado.ToString();
        }
        else
        {
            ResultadoLabel.Text = "Por favor, ingrese números válidos en ambos campos.";
        }
    }
}

