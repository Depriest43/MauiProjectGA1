namespace MauiProjectGA1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();


	}



	private void btnAdd_Clicked(object sender, EventArgs e)
	{
		//Start writing code here.
		doble.tryParse(txtNumber1.Text, out count);
		double.TryParse(txtNumber2.Text, out count);
		double result = number1 + number2;
		lblResult.Text = $("Result: {result}");
	}


	}
}

