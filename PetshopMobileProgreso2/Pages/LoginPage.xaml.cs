namespace PetshopMobileProgreso2.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	public void ClickBotonLogin(object sender, EventArgs e)
	{
		string uname = txtUsuario.Text;
		string pass = txtPass.Text;

		var user = UsersLogin.GetUsuarios().FirstOrDefault(x => x.Username == uname && x.Password == pass);
		if (user != null)
		{
			
			Navigation.PushAsync(new ProductosPage());
            Navigation.RemovePage(this);
        }
		else
		{
			
		}
	}
}