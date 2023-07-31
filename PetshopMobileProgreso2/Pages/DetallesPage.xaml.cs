using PetshopMobileProgreso2.Models;
using PetshopMobileProgreso2.Services;
using PetshopMobileProgreso2.Utils;

namespace PetshopMobileProgreso2.Pages;

public partial class DetallesPage : ContentPage
{

    Producto producto1;
	readonly IServicioApiPro _servicioApiPro = new ServicioApiPro();
    
	public DetallesPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		Producto producto = BindingContext as Producto;
		Nombre.Text = "Nombre: " + producto.Nombre;
		Descripcion.Text = "Decripción: " + producto.Descripcion;
		Precio.Text = "Precio: " +producto.Precio.ToString() +"$";
		Cantidad.Text = "Cantidad: "+producto.Cantidad.ToString();
    }

	private async void onClickAgregarACarrito(object sender, EventArgs e)
	{
		producto1 = BindingContext as Producto;
		if (producto1.Cantidad > 0)
		{
            producto1.Cantidad = producto1.Cantidad - 1;
            await _servicioApiPro.EditarProducto(producto1.Id, producto1);
            BindingContext = producto1;
			
			ListaGlobal.listaGlobalProductos.Add(producto1);
        }
		await Navigation.PopAsync();
	}

    private async void onClickRetroceder(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}

}