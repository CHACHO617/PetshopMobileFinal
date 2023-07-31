namespace PetshopMobileProgreso2.Pages;
using PetshopMobileProgreso2.Services;

public partial class LoginPage : ContentPage
{
    readonly IServicioApiCli _servicioAPiCli = new ServicioApiCli();
    public LoginPage()
	{
		InitializeComponent();
	}

	

	public async void ClickBotonLogin(object sender, EventArgs e)
	{
        string uname = txtUsuario.Text;
        string pass = txtPass.Text;

        var listaCliente = await _servicioAPiCli.ListarClientes();

		foreach (var cliente in listaCliente)
		{
			if (cliente.Email.Equals(uname))
			{
				if(cliente.Contrasena.Equals(pass))
				{
                    IngresoErroneo.Source = "https://i.ibb.co/Pj81TVg/Group-15.png";
                    await Task.Delay(2000);

                    Navigation.PushAsync(new ProductosPage());
                    Navigation.RemovePage(this);
                }
			}
			else
			{
                IngresoErroneo.Source = "https://i.ibb.co/8ccRmTj/Group-14.png";
            }
		}


		/*string uname = txtUsuario.Text;
		string pass = txtPass.Text;

		var user = UsersLogin.GetUsuarios().FirstOrDefault(x => x.Username == uname && x.Password == pass);
		if (user != null)
		{
			
			Navigation.PushAsync(new ProductosPage());
            Navigation.RemovePage(this);
        }
		else
		{
			
		}*/

	}
}