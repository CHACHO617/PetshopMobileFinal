using PetshopMobileProgreso2.Utils;

namespace PetshopMobileProgreso2.Pages;

public partial class FacturaPage : ContentPage
{
	public FacturaPage()
	{
		InitializeComponent();
	}

    private async void Finalizar_Clicked(object sender, EventArgs e)
    {
		ListaGlobal.listaGlobalProductos.Clear();
		await Navigation.PopToRootAsync();

		
    }
}