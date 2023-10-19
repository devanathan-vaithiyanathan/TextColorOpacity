namespace TextColorOpacityTesting;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void opacitySlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double opacity = e.NewValue;
        Color textColor = Colors.Red;
        Color text = new Color(textColor.Red, textColor.Green, textColor.Blue, (byte)(opacity * 255));
        myEditor.TextColor = text;
    }
}

