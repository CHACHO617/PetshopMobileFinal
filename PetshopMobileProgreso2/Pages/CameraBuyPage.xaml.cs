namespace PetshopMobileProgreso2.Pages;
using CreditCardValidator;

public partial class CameraBuyPage : ContentPage
{
	public CameraBuyPage()
	{
		InitializeComponent();
		CreditCardNumberEntry.TextChanged += CreditCardNumberEntry_TextChanged;
		CardBrandIcon.Source = "https://i.ibb.co/B4GMNh4/SVGRepo-icon-Carrier123.png";

    }
    private void CreditCardNumberEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            CreditCardDetector detector = new CreditCardDetector(CreditCardNumberEntry.Text);

            string brand = detector.BrandName;

            Console.WriteLine("***********************************Brand:" + brand);

            if (brand.Equals("Visa"))
            {
                CardBrandIcon.Source = "https://i.ibb.co/sv8SmCR/visa-svgrepo-com.png";
            }
            else if (brand.Equals("MasterCard"))
            {
                CardBrandIcon.Source = "https://i.ibb.co/fpsNhKR/mastercard-svgrepo-com.png";
            }
            else if (brand.Equals("Discover"))
            {
                CardBrandIcon.Source = "https://i.ibb.co/FYy97Hk/discover-svgrepo-com.png";
            }
            else if (brand.Equals("American Express"))
            {
                CardBrandIcon.Source = "https://i.ibb.co/vsdvhh8/amex-svgrepo-com.png";
            }
            else if (brand.Equals("Unknown"))
            {
                CardBrandIcon.Source = "https://i.ibb.co/B4GMNh4/SVGRepo-icon-Carrier123.png";
            }
        }
        catch (Exception ex)
        {
            CreditCardNumberEntry.Text = "";
            CardBrandIcon.Source = "https://i.ibb.co/B4GMNh4/SVGRepo-icon-Carrier123.png";
        }
    }

    private async void Button_Clicked1(object sender, EventArgs e)
    {
            CreditCardDetector detector = new CreditCardDetector(CreditCardNumberEntry.Text);
            string brand = detector.BrandName;
            if (brand.Equals("Unknown"))
            {
                ErrorSuccesIcon.Source = "https://i.ibb.co/QXKc4fG/Group-36.png";
            }
            else if (brand == null)
            {
                ErrorSuccesIcon.Source = "https://i.ibb.co/QXKc4fG/Group-36.png";
            }
            else if (CreditCardNumberEntry.Text == null)
            {
                ErrorSuccesIcon.Source = "https://i.ibb.co/QXKc4fG/Group-36.png";
            }
            else if (CardHolderNameEntry.Text == null)
            {
                ErrorSuccesIcon.Source = "https://i.ibb.co/sCc3C5N/Group-35.png";
            }
            else if (CardHolderNameEntry.Text.Equals(""))
            {
                ErrorSuccesIcon.Source = "https://i.ibb.co/sCc3C5N/Group-35.png";
            }
        else if (CvvEntry.Text == null)
            {
                ErrorSuccesIcon.Source = "https://i.ibb.co/4mBcT0y/error-box-svgrepo-com.png";
            }
            else if (ExpirationMonth.Text == null || Convert.ToInt32(ExpirationMonth.Text)>12)
            {
                ErrorSuccesIcon.Source = "https://i.ibb.co/P5FCVpP/Group-38.png";
            }
            else if (ExpirationYear.Text == null || Convert.ToInt32(ExpirationYear.Text) < 23)
            {
                ErrorSuccesIcon.Source = "https://i.ibb.co/P5FCVpP/Group-38.png";
            }

            else
            {
                ErrorSuccesIcon.Source = "https://i.ibb.co/1dtpzt4/check-box-svgrepo-com.png";
                await Task.Delay(2000);
                Navigation.PushAsync(new FacturaPage());
            }
        


    }
}



