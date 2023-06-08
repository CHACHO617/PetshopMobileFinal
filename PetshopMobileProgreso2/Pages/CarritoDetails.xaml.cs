using PetshopMobileProgreso2.Models;
using PetshopMobileProgreso2.Services;
using PetshopMobileProgreso2.Utils;

namespace PetshopMobileProgreso2.Pages;

public partial class CarritoDetails : ContentPage
{
    Producto producto1;
    readonly IServicioApiPro _servicioApiPro = new ServicioApiPro();
    public CarritoDetails()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Producto producto = BindingContext as Producto;
        Nombre.Text = producto.Nombre;
        Descripcion.Text = producto.Descripcion;
        Precio.Text = producto.Precio.ToString();
        Cantidad.Text = "1";
    }

    private async void onClickEliminarDeCarrito(object sender, EventArgs e)
    {
        producto1 = BindingContext as Producto;
        
            producto1.Cantidad = producto1.Cantidad + 1;
            await _servicioApiPro.EditarProducto(producto1.Id, producto1);
            BindingContext = producto1;

            ListaGlobal.listaGlobalProductos.Remove(producto1);
        
        await Navigation.PopAsync();
    }

    private async void onClickRetroceder1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}