using Windows.UI.Accessibility;
using System.Speech.Synthesis;

namespace MauiProjectGA1;

public partial class MainPage : ContentPage
{
	int count = 0;
    SpeechSynthesizer speech = new SpeechSynthesizer();

    public MainPage()
	{
		InitializeComponent();
	}



	private void btnAdd_Clicked(object sender, EventArgs e)
	{
		//Start writing code here.
		double number1 = double.Parse(txtNumber1.Text);

		double number2 = double.Parse(txtNumber2.Text);

		double result = number1 + number2;
		lblResult.Text = ($"Result: {result}");

		speech.Speak(lblResult.Text);
		

	}

    private void btnSubtract_Clicked(object sender, EventArgs e)
    {
		double number1 = double.Parse(txtNumber1.Text);
		double number2 = double.Parse(txtNumber2.Text);
		double result = number1 - number2;
		lblResult.Text = ($"Result: {result}");
		speech.Speak(lblResult.Text);
    }

    private void btnMultiply_Clicked(object sender, EventArgs e)
    {
double number1 = double.Parse(txtNumber1.Text);
		double number2 = double.Parse(txtNumber2.Text);
		double result = number1 * number2;
		lblResult.Text = ($"Result: {result}");
		speech.Speak(lblResult.Text);
    }

    private void btnDivide_Clicked(object sender, EventArgs e)
    {
double number1 = Double.Parse(txtNumber1.Text);
		double number2 = Double.Parse(txtNumber2.Text);
		double result = number1 / number2;
		lblResult.Text = ($"Result: {result}");
		speech.Speak(lblResult.Text);
    }
}


