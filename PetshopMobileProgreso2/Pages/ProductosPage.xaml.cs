using PetshopMobileProgreso2.Models;
using PetshopMobileProgreso2.Services;
using System.Collections.ObjectModel;


namespace PetshopMobileProgreso2.Pages;

public partial class ProductosPage : ContentPage
{
	readonly IServicioApiPro _servicioAPiPro = new ServicioApiPro();
	public ProductosPage()
	{
		InitializeComponent();
	}

	private async void DetalleItem(object sender, SelectedItemChangedEventArgs e)
	{
		Producto producto = (Producto)e.SelectedItem;
		await Navigation.PushAsync(new DetallesPage()
		{
			BindingContext = producto
		}) ;
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		var listaProducto = await _servicioAPiPro.ListarProductos();
		var productos = new ObservableCollection<Producto>(listaProducto);
        listaProductos.ItemsSource = productos;
	}

	private async void IrACarrito(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Carrito());
	}
 
}