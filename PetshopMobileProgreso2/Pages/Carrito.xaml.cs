using System.Collections.ObjectModel;
using PetshopMobileProgreso2.Models;
using PetshopMobileProgreso2.Utils;

namespace PetshopMobileProgreso2.Pages;

public partial class Carrito : ContentPage
{
	public Carrito()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        ListaGlobalProductos.ItemsSource = new ObservableCollection<Producto>(ListaGlobal.listaGlobalProductos);
        //ListaGlobal.listaGlobalProductos.ItemsSource = listaProductos;
        //listaProductos.ItemsSource = productos; QUIERO CONSUMIR LISTA LOCAL
        ListaGlobal list = new ListaGlobal();
        double valorPagar = list.Sumatoria();
        valorPagar = Math.Round(valorPagar, 2);
        PagarBtn.Text = $"Valor a Pagar: {valorPagar} $";

        SemanticScreenReader.Announce(PagarBtn.Text);

        if (valorPagar == 0)
        {
            Navigation.PopAsync();
        }
    }


    public double Suma()
    {
        ListaGlobal.listaGlobalProductos = new List<Producto>();
        
        double sum = 0;
        foreach (Producto product in ListaGlobal.listaGlobalProductos)
        {
            sum = sum + product.Precio;
        }
        Console.WriteLine(sum.ToString());
        return sum;
        
    }
   


    private void OnPagarClicked(object sender, EventArgs e)
	{
		ListaGlobal list = new ListaGlobal();
        double valorPagar = list.Sumatoria();

        PagarBtn.Text = $"Valor a Pagar: {valorPagar} $";
		
		SemanticScreenReader.Announce(PagarBtn.Text);

        if(valorPagar == 0)
        {
            Navigation.PopAsync();
        }
	}

    private void Redirect_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CameraBuyPage());
    }

    private async void DetalleItem1(object sender, SelectedItemChangedEventArgs e)
    {
        Producto producto = (Producto)e.SelectedItem;
        await Navigation.PushAsync(new CarritoDetails()
        {
            BindingContext = producto
        });
    }

    private void ListaGlobalProductos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

    }
}