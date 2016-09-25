
using System;
using Xamarin.Forms;

namespace CieloPay.ClientApp.App.Pages
{
    public partial class AddToCartPage : ContentPage
    {
        public AddToCartPage(int productId)
        {
            InitializeComponent();

            this.Title.Text = "X-Tudo";
            this.Description.Text = "Descrição maneira pro meu lanche mega irado que vai vender muito.";
            
            this.Image.Source = ImageSource.FromUri(new Uri("http://hotdogpontocerto.loja2.com.br/img/0c9ea046015a690e8f3db995fbd46a4f.png"));

        }
    }
}
