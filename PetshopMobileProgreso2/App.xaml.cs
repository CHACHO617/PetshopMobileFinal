using PetshopMobileProgreso2.Pages;

namespace PetshopMobileProgreso2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new NavigationPage(new CameraBuyPage());
        MainPage = new NavigationPage(new LoginPage());
    }
}
