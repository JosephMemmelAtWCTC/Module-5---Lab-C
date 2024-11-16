namespace TabFlayoutNavigation.Pages;

public partial class BMICalc : ContentPage
{
	public BMICalc()
	{
		InitializeComponent();
	}


	private void OnCounterClicked(object sender, EventArgs e)
	{
		int weight, heightFeet = 0, heightInches = 0;
		if(int.TryParse(Inp_weight.Text, out weight) && (int.TryParse(Inp_height_feet.Text, out heightFeet) | int.TryParse(Inp_height_inches.Text, out heightInches))){
			double bmi = weight / Math.Pow(heightFeet * 12 + heightInches, 2) * 703;
			Lbl_BMI.Text = $"Your BMI is {bmi}";
		}

		// ((Button) sender).Text = $"You clicked {count} times.";

		// if (count == 1)
		// 	OutText.Text = $"Clicked {count} time";
		// else
		// 	OutText.Text = $"Clicked {count} times";


		// // SemanticScreenReader.Announce(CounterBtn.Text);
		SemanticScreenReader.Announce(Lbl_BMI.Text);
		
	}
}
