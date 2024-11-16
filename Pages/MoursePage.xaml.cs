namespace TabFlayoutNavigation.Pages;

public partial class MoursePage : ContentPage
{

	MorseHolder morseHolderTop = new MorseHolder();
	MorseHolder morseHolderBottom = new MorseHolder();

	public MoursePage()
	{
		InitializeComponent();
	}

	private void MorseInputTop(object sender, EventArgs e)
	{
		var senderButton = (Button) sender;
		VisiableMorseCodeLineTop.Text = morseHolderTop.addMorse(senderButton.Text[0]);
	}

	private void MorseInputBottom(object sender, EventArgs e)
	{
		var senderButton = (Button) sender;
		VisiableMorseCodeLineBottom.Text = morseHolderBottom.addMorse(senderButton.Text[0]);
	}


	// private void OnCounterClicked(object sender, EventArgs e)
	// {
	// 	count++;

	// 	if (count == 1)
	// 		CounterBtn.Text = $"Clicked {count} time";
	// 	else
	// 		CounterBtn.Text = $"Clicked {count} times";

	// 	SemanticScreenReader.Announce(CounterBtn.Text);
	// }
}

