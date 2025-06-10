using System.Threading.Tasks;

namespace MauiApp1;

public partial class DemoPage : ContentPage
{
	public DemoPage()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());

    }


}